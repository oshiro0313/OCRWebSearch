using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OCRWebSearch
{
    public partial class MainForm1 : Form
    {
        public SettingForm sf = null;

        public MainForm1()
        {
            InitializeComponent();
            CaptureForm1 captureform1 = new CaptureForm1();
            captureform1.Show();
            captureform1.Hide();
            label1.Text = ConfigurationManager.AppSettings["ShortCutKey1"] + IsSetting(ConfigurationManager.AppSettings["ShortCutKey2"]) + ConfigurationManager.AppSettings["ShortCutKey2"] + IsSetting(ConfigurationManager.AppSettings["ShortCutKey3"]) + ConfigurationManager.AppSettings["ShortCutKey3"] +　"でキャプチャモードを起動します";
        }

        private string IsSetting(string SCkey)
        {
            if (SCkey == "")
            {
                return "";
            }
            else
            {
                return "+";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // アプリケーションの終了
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            NotifyIcon notifyIcon;
            notifyIcon = new NotifyIcon();
            // アイコンの設定

            notifyIcon.Icon = new Icon("../../Icon.ico");
            // アイコンを表示する
            notifyIcon.Visible = true;
            // アイコンにマウスポインタを合わせたときのテキスト
            notifyIcon.Text = "NotifyIconテスト";

            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = "&終了";
            toolStripMenuItem.Click += ToolStripMenuItem_Click;
            contextMenuStrip.Items.Add(toolStripMenuItem);
            notifyIcon.ContextMenuStrip = contextMenuStrip;
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            //多重起動防止
            if (this.sf == null || this.sf.IsDisposed)
            { /* ヌル、または破棄されていたら */
                this.sf = new SettingForm();
            }
        }
    }
}
