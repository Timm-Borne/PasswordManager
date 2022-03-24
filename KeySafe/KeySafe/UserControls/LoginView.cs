using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KeySafe.UserControls
{
    public partial class LoginView : UserControl
    {

        private int _seconds = 0;
        
        public LoginView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            FillFileHistory();
        }

        /// <summary>
        /// Trigger the Loginrequest event if the user want to login.
        /// </summary>
        /// <param name="filePath">Path of the file to decrypt.</param>
        /// <param name="password">Password that the user has entered in the textfield.</param>
        public delegate void OnLoginRequestDelegate(string filePath, string password);
        public event OnLoginRequestDelegate OnLoginRequest;

        private void button_login_Click(object sender, EventArgs e)
        {
            OnLoginRequest(this.listBox_saveFiles.SelectedItem.ToString(), this.textBox_pw.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_pw_KeyUp(object sender, KeyEventArgs e)
        {
            //If the user hit enter the loginrequest will also be triggered
            if(e.KeyCode == Keys.Enter)
            {
                if (this.button_login.Enabled)
                {
                    OnLoginRequest(this.listBox_saveFiles.SelectedItem.ToString(), this.textBox_pw.Text);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddExisting_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog_OpenKeySaveFile.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                Settings.Default.Files.Add(this.openFileDialog_OpenKeySaveFile.FileName);
                Settings.Default.Save();
                FillFileHistory();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CreateNew_Click(object sender, EventArgs e)
        {
            DialogResult result = this.saveFileDialog_CreateNew.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (!this.saveFileDialog_CreateNew.CheckFileExists)
                {
                    try
                    {
                        File.Create(this.saveFileDialog_CreateNew.FileName).Close();
                        Settings.Default.Files.Add(this.saveFileDialog_CreateNew.FileName);
                        Settings.Default.Save();
                        FillFileHistory();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckFiles()
        {
            string[] files = new string[Settings.Default.Files.Count];

            Settings.Default.Files.CopyTo(files, 0);

            foreach (string file in files)
            {
                if (!File.Exists(file))
                {
                    Settings.Default.Files.Remove(file);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillFileHistory()
        {
            CheckFiles();
            this.listBox_saveFiles.Items.Clear();
            foreach (string file in Settings.Default.Files)
            {
                this.listBox_saveFiles.Items.Add(file);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public delegate void OnCreatePasswordDelegate(string filename);
        public event OnCreatePasswordDelegate OnCreatePassword;

        private void listBox_saveFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.listBox_saveFiles.SelectedIndex >= 0)
                {
                    this.button_login.Enabled = true;
                    if (String.IsNullOrEmpty(File.ReadAllText(this.listBox_saveFiles.SelectedItem.ToString())))
                    {
                        string text = "The file did not been used before. Please set a password to encrypt the file.";
                        DialogResult dialogresult = MessageBox.Show(text, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogresult == DialogResult.OK)
                        {
                            OnCreatePassword(this.listBox_saveFiles.SelectedItem.ToString());
                        }
                        else
                        {
                            this.listBox_saveFiles.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    this.button_login.Enabled = false;
                }
            }
            catch (FileNotFoundException)
            {
                OnLoginRequest(this.listBox_saveFiles.SelectedItem.ToString(), this.textBox_pw.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CancelLogin()
        {
            this.listBox_saveFiles.SelectedIndex = -1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox_pw.PasswordChar = '\0';
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.textBox_pw.PasswordChar = '*';
        }
    }
}