using System;
using System.Windows.Forms;

namespace CertificateTool
{
    public partial class PasswordBoxWithToggle : UserControl
    {
        private bool isPasswordVisible = false;

        public PasswordBoxWithToggle()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            picToggle.Image = Properties.Resources.eye_closed;
            picToggle.Cursor = Cursors.Hand;
            picToggle.Click += ToggleVisibility;
        }

        private void ToggleVisibility(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            picToggle.Image = isPasswordVisible ? Properties.Resources.eye_open : Properties.Resources.eye_closed;
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public override string Text
        {
            get => Password;
            set => Password = value;
        }

        public event EventHandler PasswordChanged
        {
            add { txtPassword.TextChanged += value; }
            remove { txtPassword.TextChanged -= value; }
        }
    }
}
