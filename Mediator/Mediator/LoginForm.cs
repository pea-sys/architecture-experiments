using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class LoginForm : System.Windows.Forms.Form, Mediator
    {
        public LoginForm()
        {
            InitializeComponent();
            BackColor = Color.LightGray;
            CreateColleagues();
            ColleagueChanged();
        }
        public virtual void CreateColleagues()
        {
            GuestRadioButton.SetMediator(this);
            LoginRadioButton.SetMediator(this);
            usernameTextBox.SetMediator(this);
            passwordTextBox.SetMediator(this);
            okButton.SetMediator(this);
            cancelButton.SetMediator(this);
        }

        public void ColleagueChanged()
        {
            if (GuestRadioButton.Checked)
            {
                usernameTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
                okButton.Enabled = true;
            }
            else
            {
                usernameTextBox.Enabled = true;
                UserPassChanged();
            }
            LoginRadioButton.Checked = !GuestRadioButton.Checked;
        }
        private void UserPassChanged()
        {
            if (usernameTextBox.Text.Length > 0)
            {
                passwordTextBox.Enabled=true;
                okButton.Enabled=(passwordTextBox.Text.Length > 0);
            }
            else
            {
                passwordTextBox.Enabled=false;
                okButton.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender + " : " + e.ToString());
            Close();
        }
    }
}
