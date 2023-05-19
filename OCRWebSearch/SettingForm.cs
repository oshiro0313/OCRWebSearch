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
    public partial class SettingForm : Form
    {
        int RegisterReception; //ショートカットキーの登録受付
        string SC1key = ConfigurationManager.AppSettings["ShortCutKey1"];//ショートカットキーの登録用
        string SC2key = ConfigurationManager.AppSettings["ShortCutKey2"];
        string SC3key = ConfigurationManager.AppSettings["ShortCutKey3"];
        string SC1keycode = ConfigurationManager.AppSettings["ShortCutKey1_code"];//ショートカットキーの登録用
        string SC2keycode = ConfigurationManager.AppSettings["ShortCutKey2_code"];
        string SC3keycode = ConfigurationManager.AppSettings["ShortCutKey3_code"];

        KeyboardHook keyboardHook = new KeyboardHook();

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        protected override void OnLoad(EventArgs e)
        {
            keyboardHook.KeyDownEvent += KeyboardHook_KeyDownEvent;
            keyboardHook.Hook();
            labelSC1.Text = ConfigurationManager.AppSettings["ShortCutKey1"];
            labelSC2.Text = ConfigurationManager.AppSettings["ShortCutKey2"];
            labelSC3.Text = ConfigurationManager.AppSettings["ShortCutKey3"];
        }

        private void KeyboardHook_KeyDownEvent(object sender, KeyEventArg e)
        {
            KeysConverter kc = new KeysConverter();
            switch (RegisterReception)
            {
                case 1:
                    SC1key = kc.ConvertToString(e.KeyCode);
                    SC1keycode = Convert.ToString(e.KeyCode);
                    labelSC1.Text = SC1key;
                    RegisterReception = 0;
                    labelExplanation.Text = null;
                    labelSC1.BackColor = Color.White;
                    break;
                case 2:
                    SC2key = kc.ConvertToString(e.KeyCode);
                    SC2keycode = Convert.ToString(e.KeyCode);
                    labelSC2.Text = SC2key;
                    RegisterReception = 0;
                    labelExplanation.Text = null;
                    labelSC1.BackColor = Color.White;
                    break;
                case 3:
                    SC3key = kc.ConvertToString(e.KeyCode);
                    SC3keycode = Convert.ToString(e.KeyCode);
                    labelSC3.Text = SC3key;
                    RegisterReception = 0;
                    labelExplanation.Text = null;
                    labelSC1.BackColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            keyboardHook.UnHook();
        }
        public SettingForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelSC1_Click(object sender, EventArgs e)
        {
            //あとでまとめる？？ 
            RegisterReception = 1;
            labelExplanation.Text = "ショートカットキー1に登録したいキーを入力してください";
            labelSC1.BackColor = Color.Aquamarine;
            labelSC2.BackColor = Color.White;
            labelSC3.BackColor = Color.White;
        }

        private void labelSC2_Click(object sender, EventArgs e)
        {
            RegisterReception = 2;
            labelExplanation.Text = "ショートカットキー2に登録したいキーを入力してください";
            labelSC2.BackColor = Color.Aquamarine;
            labelSC1.BackColor = Color.White;
            labelSC3.BackColor = Color.White;
        }

        private void labelSC3_Click(object sender, EventArgs e)
        {
            RegisterReception = 3;
            labelExplanation.Text = "ショートカットキー3に登録したいキーを入力してください";
            labelSC3.BackColor = Color.Aquamarine;
            labelSC1.BackColor = Color.White;
            labelSC2.BackColor = Color.White;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(SC1key == "")
            {
                if(SC2key == "")
                {
                    config.AppSettings.Settings["ShortCutKey1"].Value = SC3key;
                    config.AppSettings.Settings["ShortCutKey1_code"].Value = SC3keycode;
                    config.AppSettings.Settings["ShortCutKey2"].Value = SC2key;
                    config.AppSettings.Settings["ShortCutKey2_code"].Value = SC2keycode;
                    config.AppSettings.Settings["ShortCutKey3"].Value = null;
                    config.AppSettings.Settings["ShortCutKey3_code"].Value = "-1";
                    MessageBox.Show("1,2null");
                }
                else
                {
                    config.AppSettings.Settings["ShortCutKey1"].Value = SC2key;
                    config.AppSettings.Settings["ShortCutKey1_code"].Value = SC2keycode;
                    config.AppSettings.Settings["ShortCutKey2"].Value = null;
                    config.AppSettings.Settings["ShortCutKey2_code"].Value = "-1";
                    MessageBox.Show("1null");
                    if (SC3key != "")
                    {
                        config.AppSettings.Settings["ShortCutKey2"].Value = SC3key;
                        config.AppSettings.Settings["ShortCutKey2_code"].Value = SC3keycode;
                        config.AppSettings.Settings["ShortCutKey3"].Value = null;
                        config.AppSettings.Settings["ShortCutKey3_code"].Value = "-1";
                        MessageBox.Show("3!null");
                    }
                }
            }
            else
            {
                config.AppSettings.Settings["ShortCutKey1"].Value = SC1key;
                config.AppSettings.Settings["ShortCutKey1_code"].Value = SC1keycode;
                if (SC2key == "")
                {
                    config.AppSettings.Settings["ShortCutKey2"].Value = SC3key;
                    config.AppSettings.Settings["ShortCutKey2_code"].Value = SC3keycode;
                    config.AppSettings.Settings["ShortCutKey3"].Value = null;
                    config.AppSettings.Settings["ShortCutKey3_code"].Value = "-1";
                }
                else
                {
                    config.AppSettings.Settings["ShortCutKey2"].Value = SC2key;
                    config.AppSettings.Settings["ShortCutKey2_code"].Value = SC2keycode;
                    config.AppSettings.Settings["ShortCutKey3"].Value = SC3key;
                    config.AppSettings.Settings["ShortCutKey3_code"].Value = SC3keycode;
                }

            }
            MessageBox.Show("設定を保存しました");
            config.Save();
            Application.Restart();
        }

        private void SCdelete1_Click(object sender, EventArgs e)
        {
            labelSC1.Text = null;
            SC1key = "";
            SC1keycode = "-1";
        }

        private void SCdelete2_Click(object sender, EventArgs e)
        {
            labelSC2.Text = null;
            SC2key = "";
            SC2keycode = "-1";
        }

        private void SCdelete3_Click(object sender, EventArgs e)
        {
            labelSC3.Text = null;
            SC3key = "";
            SC3keycode = "-1";
        }
    }
}
