using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace AsociacionCivil
{
    public partial class RegisterPeriod : Form
    {
        public RegisterPeriod()
        {
            InitializeComponent();

            this.numYear.Maximum = DateTime.Now.Year;
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInsertNew_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT per_inicio FROM periodo", connection);
                bool validYear = true;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        if (DateTime.Parse(reader["per_inicio"].ToString()).Year == this.numYear.Value)
                        {
                            MessageBox.Show("Ya existe ese periodo.", "Periodo duplicado");
                            validYear = false;
                        }
                    }
                }

                if (validYear)
                {
                    string startDate = DateTime.Parse($"{numYear.Value.ToString()}-01-01").ToString();
                    string endDate = DateTime.Parse($"{numYear.Value.ToString()}-12-31").ToString();

                    using (SqlCommand command2 = new SqlCommand("INSERT INTO periodo VALUES (@per_inicio, @per_fin)", connection))
                    {
                        command2.Parameters.AddWithValue("per_inicio", startDate);
                        command2.Parameters.AddWithValue("per_fin", endDate);
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Periodo abierto exitosamente.", "Apertura exitosa");
                    }
                }
            }
        }
    }
}
