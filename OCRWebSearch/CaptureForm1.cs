using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Configuration;

namespace OCRWebSearch
{
    public partial class CaptureForm1 : Form
    {
        private Point startPos;
        private Point currentPos;

        private bool drawing;

        private KeyboardHook keyboardHook = new KeyboardHook();

        private bool keypressSC1;
        private bool keypressSC2;
        private bool keypressSC3;
        private int keycodeSC1 = Convert.ToInt32(ConfigurationManager.AppSettings["ShortCutKey1_code"]);
        private int keycodeSC2 = Convert.ToInt32(ConfigurationManager.AppSettings["ShortCutKey2_code"]);
        private int keycodeSC3 = Convert.ToInt32(ConfigurationManager.AppSettings["ShortCutKey3_code"]);

        public CaptureForm1()
        {
            InitializeComponent();

            this.MouseDown += Canvas_MouseDown;
            this.MouseMove += Canvas_MouseMove;
            this.MouseUp += Canvas_MouseUp;
            this.Paint += Canvas_Paint;
            this.KeyDown += Canvas_KeyDown;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Opacity = 0.1;
            this.Cursor = Cursors.Cross;
            this.DoubleBuffered = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            keyboardHook.KeyDownEvent += KeyboardHook_KeyDownEvent;
            keyboardHook.KeyUpEvent += KeyboardHook_KeyUpEvent;
            keyboardHook.Hook();
        }

        private void KeyboardHook_KeyDownEvent(object sender, KeyEventArg e)
        {
            KeysConverter kc = new KeysConverter();
            if (e.KeyCode == keycodeSC1)
            {
                keypressSC1 = true;
                CanCapturemode();
            }
            if (e.KeyCode == keycodeSC2)
            {
                keypressSC2 = true;
                CanCapturemode();
            }
            if (e.KeyCode == keycodeSC3)
            {
                keypressSC3 = true;
                CanCapturemode();
            }
        }

        private void KeyboardHook_KeyUpEvent(object sender, KeyEventArg e)
        {
            KeysConverter kc = new KeysConverter();
            if (e.KeyCode == keycodeSC1)
            {
                keypressSC1 = false;
            }
            else if (e.KeyCode == keycodeSC2)
            {
                keypressSC2 = false;
            }
            else if (e.KeyCode == keycodeSC3)
            {
                keypressSC3 = false;
            }
        }
        
        private void CanCapturemode()
        {
            if(keycodeSC2 == -1)
            {
                if(keypressSC1)
                {
                    this.Show();
                }
            }
            if(keycodeSC3 == -1)
            {
                if (keypressSC1 && keypressSC2)
                {
                    this.Show();
                }
            }
            else
            {
                if (keypressSC1 && keypressSC2 && keypressSC3)
                {
                    this.Show();
                }
            }
        }

        private void ScreenCapture()
        {
            Rectangle rect = GetRectangle();
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
            graphics.Dispose();
            //pngファイルのほうが文字認識の精度がいいらしい
            bmp.Save("Text.png", System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();
            var engine = new TesseractEngine("../../", "jpn");
            Pix pix = Pix.LoadFromFile("Text.png");
            var page = engine.Process(pix);
            string word = (page.GetText());
            Process ps = new Process();
            ps.StartInfo.UseShellExecute = true;
            ps.StartInfo.FileName = "https://www.google.com/search?q=" + word + "&oq=%UE3%81%82%E3%81%82%E3%81%82&aqs=chrome..69i57j69i59j0i131i433i512l2j0i512l4j0i4i131i433i512j0i4i512.1619j0j15&sourceid=chrome&ie=UTF-8";
            ps.Start();
        }
        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Hide();
                drawing = false;
            }
        }
        private Rectangle GetRectangle()
        {
            //矩形領域が点になっていたらbmpに格納時エラーが出る
            if (startPos.X == currentPos.X)
            {
                startPos.X += 1;
            }

            if (startPos.Y == currentPos.Y)
            {
                startPos.Y += 1;
            }
            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            currentPos = startPos = e.Location;
            drawing = true;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            currentPos = e.Location;
            if (drawing)
            {
                this.Invalidate();
            }

        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            drawing = false;
            this.Hide();
            ScreenCapture();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (drawing)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
            }
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            keyboardHook.UnHook();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
