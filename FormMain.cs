using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OFA.Test.Progs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            try
            {
                Log.SetLogDirectory(true, $@"\Tmp\POC_Logs\");

                Log.WriteFileLog("============================");
                Log.WriteFileLog("=== START TOOL CRYPTO");
                //Log.WriteFileLog($"=== Log: {Log.GetLogDirectory()}");
                Log.WriteFileLog("============================");
                //Log.WriteFileLog("############################");
            }
            catch (Exception ex)
            {
                Log.WriteFileLog("=== ERROR  ===");
                Log.WriteFileLog($"{ex.Message}", LogMsgType.ERROR);

                this.Close();
            }

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {

            //Log.WriteFileLog("############################");
            Log.WriteFileLog("============================");
            Log.WriteFileLog("=== END TOOL CRYPTO");
            Log.WriteFileLog("============================");
            }
        }

        private void button_Encode_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox_SecretKey.Text) || textBox_SecretKey.Text.Length != 8)
            {
                string strMsg = "Secret Key must be 8 symbols length exactly!";
                Log.WriteFileLog($"{strMsg}", LogMsgType.WARNING);
                MessageBox.Show(strMsg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (String.IsNullOrWhiteSpace(textBox_OriginalString.Text))
                {
                    string strMsg = "Origial string must set!";
                    Log.WriteFileLog($"{strMsg}", LogMsgType.WARNING);
                    MessageBox.Show(strMsg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();

                    textBox_Encoded.Text = CryptString2.Encrypt(textBox_OriginalString.Text, textBox_SecretKey.Text);
                    textBox_Decoded.Text = CryptString2.Decrypt(textBox_Encoded.Text, textBox_SecretKey.Text);

                    textBox_XML.Text = $@"<add key=""[KEY]"" value=""{textBox_Encoded.Text}"" />";

                    Log.WriteFileLog("Successfully generating XML");
                    Log.WriteFileLog($"{textBox_XML.Text}", LogMsgType.MESSAGE);

                }
            }
        }

        private void button_CopyXMLToClipboard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_XML.Text))
            {
                string strMsg = "Nothig to copy from XML box";
                Log.WriteFileLog($"{strMsg}", LogMsgType.WARNING);
                MessageBox.Show(strMsg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clipboard.SetText(textBox_XML.Text);
            }
        }

        private void button_CopyEncodedToClipboard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Encoded.Text))
            {
                string strMsg = "Nothig to copy from encoded string";
                Log.WriteFileLog($"{strMsg}", LogMsgType.WARNING);
                MessageBox.Show(strMsg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clipboard.SetText(textBox_Encoded.Text);
            }
        }
    }
}
