using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace AsociacionCivil
{
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin(string rfc, string name, string pLastName, string mLastName, string pc, string extNum, string street, string suburb, string city, int state, string startDate, string intNum = "", string email = "", string exitDate = "", string status = "")
        {
            InitializeComponent();
            FillStates();
            this.mmtxtRFC.Text = rfc;
            this.mmtxtName.Text = name;
            this.mmtxtPLastName.Text = pLastName;
            this.mmtxtMLastName.Text = mLastName;
            this.mcmbState.SelectedIndex = state;

            FillCities();
            this.mcmbCity.SelectedIndex = this.mcmbCity.FindStringExact(city);
            this.mmtxtPostalCode.Text = pc;
            this.mmtxtIntNum.Text = intNum;
            this.mmtxtExtNum.Text = extNum;
            this.mmtxtEmail.Text = email;

            if (status == "A")
            {
                this.mrbActive.Checked = true;
                this.dtpExitDate.Visible = false;
                this.lblExitDate.Visible = false;
            }
            else
            {
                this.mrbInactive.Checked = true;
                this.dtpExitDate.Visible = true;
                this.lblExitDate.Visible = true;
                this.dtpExitDate.Value = DateTime.Parse(exitDate);
            }

            this.mmtxtStreet.Text = street;
            this.mmtxtSuburb.Text = suburb;
            this.dtpAssociationDate.Value = DateTime.Parse(startDate);
            
            //dtpExitDate.Value = DateTime.Parse(DateTime.Parse(fechasalida).ToString("yyyy-MM-dd"));
            /*DateTime exitDate;
            if (DateTime.TryParse(exitDate, out exitDate))
            {
                dtpExitDate.Value = exitDate;
            }
            else
            {
                // El valor de exitdate no es una fecha válida
            }*/
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void FillStates()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM estado";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mcmbState.Items.Add(reader["nombre"]);
                    }
                }
            }
        }
        public void FillCities()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                int estado = mcmbState.SelectedIndex + 1;
                string query = "SELECT * FROM ciudad WHERE estado_num = @estado_num";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@estado_num", estado);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CityItem cityItem = new CityItem((int)reader["ciudad_id"], (string)reader["nombre"]);
                        mcmbCity.Items.Add(cityItem);
                    }
                }
            }
        }

        private void RebuildQuery(ref string selectedFields)
        {
            //Check if the non required fields have been filled

            //Check for email
            if (!String.IsNullOrEmpty(mmtxtEmail.Text) && !String.IsNullOrWhiteSpace(mmtxtEmail.Text))
            {
                selectedFields += ", email = @email";
            }

            //Check for interior number
            if (!String.IsNullOrEmpty(mmtxtIntNum.Text) && !String.IsNullOrWhiteSpace(mmtxtIntNum.Text))
            {
                selectedFields += ", num_int = @num_int";
            }

            if (mrbInactive.Checked == true)
            {
                selectedFields += ", fecha_salida = @fecha_salida";
            }
        }

        private SqlCommand AddMissingFields(SqlCommand command, string fields)
        {
            if (fields.Contains("email"))
            {
                command.Parameters.AddWithValue("@email", mmtxtEmail.Text);
            }

            if (fields.Contains("num_int"))
            {
                command.Parameters.AddWithValue("@num_int", int.Parse(mmtxtIntNum.Text));
            }

            if (fields.Contains("fecha_salida"))
            {
                command.Parameters.AddWithValue("@fecha_salida", dtpExitDate.Value.ToString("yyyy-MM-dd"));
            }

            return command;
        }

        private void btnInsertNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    connection.Open();

                    string selectedFields = "nombre = @nombre, apellido_pat = @apellido_pat, apellido_mat = @apellido_mat, calle = @calle, num_ext = @num_ext, codigo_postal = @codigo_postal, colonia = @colonia, fecha_inicio = @fecha_inicio, estatus = @estatus, ciudad_id = @ciudad_id";

                    RebuildQuery(ref selectedFields);

                    SqlCommand command = new SqlCommand($"UPDATE administrador SET {selectedFields} WHERE adm_rfc = @adm_rfc", connection);
                    command.Parameters.AddWithValue("@adm_rfc", mmtxtRFC.Text);
                    command.Parameters.AddWithValue("@nombre", mmtxtName.Text);
                    command.Parameters.AddWithValue("@apellido_pat", mmtxtPLastName.Text);
                    command.Parameters.AddWithValue("@apellido_mat", mmtxtMLastName.Text);
                    command.Parameters.AddWithValue("@calle", mmtxtStreet.Text);
                    command.Parameters.AddWithValue("@num_ext", mmtxtExtNum.Text);
                    command.Parameters.AddWithValue("@codigo_postal", mmtxtPostalCode.Text);
                    command.Parameters.AddWithValue("@colonia", mmtxtSuburb.Text);
                    command.Parameters.AddWithValue("@fecha_inicio", dtpAssociationDate.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@estatus", GetPersonState());
                    command.Parameters.AddWithValue("@ciudad_id", (int)((CityItem)mcmbCity.SelectedItem).Index);

                    command = AddMissingFields(command, selectedFields);

                    command.ExecuteNonQuery();


                    MessageBox.Show("Datos del administrador actualizados con éxito.", "Actualización exitosa");

                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Dispose();
        }

        private void mcmbState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mcmbCity.Items.Clear();
            FillCities();
        }
        private string GetPersonState()
        {
            string person = "";

            person = (mrbActive.Checked == true) ? "A" : "D";

            return person;
        }

        private void mmtxtName_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtName.Text.Length > 20)
            {
                this.mmtxtName.Text = this.mmtxtName.Text.Substring(0, 20);
                this.mmtxtName.SelectionStart = this.mmtxtName.Text.Length;
            }
        }

        private void mmtxtPLastName_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtPLastName.Text.Length > 20)
            {
                this.mmtxtPLastName.Text = this.mmtxtPLastName.Text.Substring(0, 20);
                this.mmtxtPLastName.SelectionStart = this.mmtxtPLastName.Text.Length;
            }
        }

        private void mmtxtMLastName_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtMLastName.Text.Length > 20)
            {
                this.mmtxtMLastName.Text = this.mmtxtMLastName.Text.Substring(0, 20);
                this.mmtxtMLastName.SelectionStart = this.mmtxtMLastName.Text.Length;
            }
        }

        private void mmtxtRFC_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtRFC.Text.Length > 13)
            {
                this.mmtxtRFC.Text = this.mmtxtRFC.Text.Substring(0, 13);
                this.mmtxtRFC.SelectionStart = this.mmtxtRFC.Text.Length;
            }
        }

        private void mmtxtSuburb_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtSuburb.Text.Length > 30)
            {
                this.mmtxtSuburb.Text = this.mmtxtSuburb.Text.Substring(0, 30);
                this.mmtxtSuburb.SelectionStart = this.mmtxtSuburb.Text.Length;
            }
        }

        private void mmtxtStreet_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtStreet.Text.Length > 30)
            {
                this.mmtxtStreet.Text = this.mmtxtStreet.Text.Substring(0, 30);
                this.mmtxtStreet.SelectionStart = this.mmtxtStreet.Text.Length;
            }
        }
    }
}

