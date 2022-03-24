using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySafe
{
    public partial class CreatePassword : Form
    {
        private string _password = string.Empty;
        public string Password
        {
            get { return _password; }
        }


        public CreatePassword()
        {
            InitializeComponent();
        }

        private void button_Okay_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Password.Text != string.Empty)
                {
                    if (textBox_Password.Text.Equals(textBoxRepeatPassword.Text))
                    {
                        this._password = textBox_Password.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        throw new ArgumentException("Passwords need to be the same.");
                    }
                }
                else
                {
                    throw new ArgumentException("The password cant be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox_ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox_Password.PasswordChar = '\0';
        }

        private void pictureBox_ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.textBox_Password.PasswordChar = '*';
        }

        private void pictureBox_ShowRepeatPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBoxRepeatPassword.PasswordChar = '\0';
        }

        private void pictureBox_ShowRepeatPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.textBoxRepeatPassword.PasswordChar = '*';
        }
    }
}
