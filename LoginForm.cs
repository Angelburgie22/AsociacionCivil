using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Windows.Forms;

namespace AsociacionCivil
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitialConfiguration();
            InitialState();
            mmtxtPassword.PasswordChar = '●';
            mmtxtUsername.Text = "";
            mmtxtUsername.Hint = "Nombre de usuario";
            mmtxtPassword.Text = "";
            mmtxtPassword.Hint = "Contraseña";
        }
        private void InitialState()
        {
            Dictionary<string, string> usernameProperties = (Dictionary<string, string>)this.mmtxtUsername.Tag;
            Dictionary<string, string> passwordProperties = (Dictionary<string, string>)this.mmtxtPassword.Tag;

            this.mmtxtUsername.ForeColor = SystemColors.ControlDarkDark;
            this.mmtxtPassword.ForeColor = SystemColors.ControlDarkDark;

            this.mmtxtUsername.Text = usernameProperties["Placeholder"];
            this.mmtxtPassword.Text = passwordProperties["Placeholder"];

            this.mmtxtUsername.UseSystemPasswordChar = false;
            this.mmtxtPassword.UseSystemPasswordChar = false;
            this.mmtxtPassword.PasswordChar = '\0';
        }
        private void InitialConfiguration()
        {
            this.mmtxtUsername.MaxLength = 20;
            this.mmtxtPassword.MaxLength = 20;
            Dictionary<string, string> usernameProperties = new Dictionary<string, string>();
            usernameProperties.Add("Placeholder", "Nombre de usuario");
            usernameProperties.Add("Type", "Input");

            Dictionary<string, string> passwordProperties = new Dictionary<string, string>();
            passwordProperties.Add("Placeholder", "Contraseña");
            passwordProperties.Add("Type", "Password");

            this.mmtxtUsername.Tag = usernameProperties;
            this.mmtxtPassword.Tag = passwordProperties;

            //this.mmtxtUsername.GotFocus += OnFocus;
            //this.mmtxtUsername.LostFocus += OnDefocus;

            //this.mmtxtPassword.GotFocus += OnFocus;
            //this.mmtxtPassword.LostFocus += OnDefocus;
        }

        /*private void OnFocus(object sender, EventArgs e)
        {
            var input = sender as MaskedTextBox;
            Dictionary<string, string> inputProperties = (Dictionary<string, string>)input.Tag;
            string placeholder = inputProperties["Placeholder"];

            if (String.IsNullOrWhiteSpace(input.Text) || input.Text == placeholder)
            {
                input.Text = "";
                input.ForeColor = Color.Black;

                if (inputProperties["Type"] == "Password")
                    input.PasswordChar = '●';
            }
        }*/

        /*private void OnDefocus(object sender, EventArgs e)
        {
            var input = sender as MaskedTextBox;
            Dictionary<string, string> inputProperties = (Dictionary<string, string>)input.Tag;
            string placeholder = inputProperties["Placeholder"];
            //MessageBox.Show(input.Text);

            if (String.IsNullOrWhiteSpace(input.Text) || input.Text == placeholder)
            {
                if (inputProperties["Type"] == "Password")
                    input.PasswordChar = '\0';

                input.Text = placeholder;
                input.ForeColor = SystemColors.ControlDarkDark;
            }
        }*/

        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            string response = Login.TryLogin(this.mmtxtUsername.Text, this.mmtxtPassword.Text);
            
            if(response == "success")
            {
                HomeForm main = new HomeForm(this);
                this.Hide();
                main.Show();
            }
        }

        private void mmtxtUsername_TextChanged(object sender, EventArgs e)
        {
            if(this.mmtxtUsername.Text.Length > 20)
            {
                this.mmtxtUsername.Text = this.mmtxtUsername.Text.Substring(0, 20);
                this.mmtxtUsername.SelectionStart = this.mmtxtUsername.Text.Length;
            }
        }

        private void mmtxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtPassword.Text.Length > 20)
            {
                this.mmtxtPassword.Text = this.mmtxtPassword.Text.Substring(0, 20);
                this.mmtxtPassword.SelectionStart = this.mmtxtPassword.Text.Length;
            }
        }
    }
}
