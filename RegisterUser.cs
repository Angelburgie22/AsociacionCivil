using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCivil
{
    public partial class RegisterUser : Form
    {
        int adminIndex;

        public RegisterUser(int adminIndex)
        {
            InitializeComponent();
            this.adminIndex = adminIndex;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mbtnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (mmtxtUsername.Text.Length < 8)
                {
                    MessageBox.Show("El nombre de usuario es muy corto. Utilice 8 caractéres.", "Longitud del nombre de usuario");
                }
                else if (mmtxtPassword.Text.Length < 8)
                {
                    MessageBox.Show("La contraseña es muy corta. Utilice 8 caractéres.", "Longitud de la contraseña");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        connection.Open();

                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(mmtxtPassword.Text);

                        SqlCommand command = new SqlCommand("INSERT INTO usuario(nombre_usuario, hash_passwd, nivel_usuario, adm_id) values (@nombre_usuario, @hash_passwd, @nivel_usuario, @adm_id)", connection);
                        command.Parameters.AddWithValue("nombre_usuario", mmtxtUsername.Text);
                        command.Parameters.AddWithValue("hash_passwd", hashedPassword);
                        command.Parameters.AddWithValue("adm_id", adminIndex);
                        command.Parameters.AddWithValue("nivel_usuario", GetUserTypeSelected());

                        command.ExecuteNonQuery();

                        MessageBox.Show("El usuario se ha añadido con éxito.", "Usuario añadido");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error en el intento");
            }

            this.Dispose();
        }
        private string GetUserTypeSelected()
        {
            string person = "";

            person = (mrbELevel.Checked == true) ? "E" : "A";

            return person;
        }

        private void mmtxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtUsername.Text.Length > 20)
            {
                this.mmtxtUsername.Text = this.mmtxtUsername.Text.Substring(0, 20);
                this.mmtxtUsername.SelectionStart = this.mmtxtUsername.Text.Length;
            }
        }

        private void mmtxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtUsername.Text.Length > 16)
            {
                this.mmtxtUsername.Text = this.mmtxtUsername.Text.Substring(0, 16);
                this.mmtxtUsername.SelectionStart = this.mmtxtUsername.Text.Length;
            }
        }
    }
}
