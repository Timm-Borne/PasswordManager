using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySafe.UserControls
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Trigger the Loginrequest event if the user want to login.
        /// </summary>
        /// <param name="password">The password that the user has entered in the textfield.</param>
        public delegate void OnLoginRequestDelegate(string password);
        public event OnLoginRequestDelegate OnLoginRequest;

        private void button_login_Click(object sender, EventArgs e)
        {
            OnLoginRequest(this.textBox_pw.Text);
        }

        private void textBox_pw_KeyUp(object sender, KeyEventArgs e)
        {
            //If the user hit enter the loginrequest will also be triggered
            if(e.KeyCode == Keys.Enter)
            {
                OnLoginRequest(this.textBox_pw.Text);
            }
        }
    }
}