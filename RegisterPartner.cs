using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AsociacionCivil
{
    public partial class RegisterPartner : Form
    {
        public RegisterPartner()
        {
            InitializeComponent();
            FillStates();
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

        private void RebuildQuery(ref string selectedFields, ref string selectedValues)
        {
            //Check if the non required fields have been filled

            //Check for email
            if (!String.IsNullOrEmpty(mmtxtEmail.Text) && !String.IsNullOrWhiteSpace(mmtxtEmail.Text))
            {
                selectedFields += ", email";
                selectedValues += ", @email";
            }

            //Check for interior number
            if (!String.IsNullOrEmpty(mmtxtIntNum.Text) && !String.IsNullOrWhiteSpace(mmtxtIntNum.Text))
            {
                selectedFields += ", num_int";
                selectedValues += ", @num_int";
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

            return command;
        }

        private void btnInsertNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    connection.Open();

                    string selectedFields = "soc_rfc, tipo_persona, nombre, apellido_pat, apellido_mat, calle, codigo_postal, colonia, ciudad_id, estatus_asociacion, fecha_nacimiento, fecha_ingreso, num_ext";
                    string selectedValues = "@soc_rfc, @tipo_persona, @nombre, @apellido_pat, @apellido_mat, @calle, @codigo_postal, @colonia, @ciudad_id, @estatus_asociacion, @fecha_nacimiento, @fecha_ingreso, @num_ext";

                    RebuildQuery(ref selectedFields, ref selectedValues);

                    SqlCommand command = new SqlCommand($"INSERT INTO socio({selectedFields}) VALUES ({selectedValues})", connection);
                    command.Parameters.AddWithValue("soc_rfc", mmtxtRFC.Text);
                    command.Parameters.AddWithValue("tipo_persona", GetPersonTypeSelected());
                    command.Parameters.AddWithValue("nombre", mmtxtName.Text);
                    command.Parameters.AddWithValue("apellido_pat", mmtxtPLastName.Text);
                    command.Parameters.AddWithValue("apellido_mat", mmtxtMLastName.Text);
                    command.Parameters.AddWithValue("calle", mmtxtStreet.Text);
                    command.Parameters.AddWithValue("codigo_postal", mmtxtPostalCode.Text);
                    command.Parameters.AddWithValue("colonia", mmtxtSuburb.Text);
                    command.Parameters.AddWithValue("ciudad_id", (int)((CityItem)mcmbCity.SelectedItem).Index);
                    command.Parameters.AddWithValue("estatus_asociacion", "A");
                    command.Parameters.AddWithValue("fecha_nacimiento", dtpBirthDate.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("fecha_ingreso", dtpAssociationDate.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("num_ext", int.Parse(mmtxtExtNum.Text));

                    command = AddMissingFields(command, selectedFields);

                    command.ExecuteNonQuery();

                    command.Dispose();

                    foreach (var phoneField in this.tlpPhoneFields.Controls.OfType<MaterialMaskedTextBox>())
                    {
                        string phone = phoneField.Text;

                        if(String.IsNullOrEmpty(phone) == false && String.IsNullOrWhiteSpace(phone) == false)
                        {
                            if(Regex.IsMatch(phone, @"^\d{10}$"))
                            {
                                using(SqlCommand command2 = new SqlCommand("INSERT INTO telefono (soc_rfc, tel_numero_telefono, tel_tipo) VALUES (@soc_rfc, @tel_numero_telefono, @tel_tipo)", connection))
                                {
                                    command2.Parameters.AddWithValue("soc_rfc", mmtxtRFC.Text);
                                    command2.Parameters.AddWithValue("tel_numero_telefono", phone);
                                    command2.Parameters.AddWithValue("tel_tipo", "Personal");

                                    command2.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Socio dado de alta con éxito.", "Registro exitoso");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Dispose();
        }
        private string GetPersonTypeSelected()
        {
            string person = "";

            person = (mrbFPerson.Checked == true) ? "F" : "M";

            return person;
        }

        private void btnAddPhoneField_Click(object sender, EventArgs e)
        {
            AddPhoneField();
        }
        private void AddPhoneField(string phoneNum = "", string phoneType = "")
        {
            int childrenCount = this.tlpPhoneFields.RowCount; //1 means there is just the add button, more than that means there are phone field
            var newPhoneField = CreatePhoneField(childrenCount, phoneNum);
            var newPhoneTypeField = CreatePhoneTypeField(childrenCount, phoneType);

            this.tlpPhoneFields.RowCount++;
            this.tlpPhoneFields.SetRow(this.btnAddPhoneField, childrenCount);
            this.tlpPhoneFields.SetColumn(this.btnAddPhoneField, 0);

            this.tlpPhoneFields.Controls.Add(newPhoneField);
            this.tlpPhoneFields.SetRow(newPhoneField, childrenCount - 1);
            this.tlpPhoneFields.SetColumn(newPhoneField, 0);
            this.tlpPhoneFields.Controls.Find(newPhoneField.Name, true)[0].GotFocus += mmtxtPhoneField_OnFocus;

            this.tlpPhoneFields.Controls.Add(newPhoneTypeField);
            this.tlpPhoneFields.SetRow(newPhoneTypeField, childrenCount - 1);
            this.tlpPhoneFields.SetColumn(newPhoneTypeField, 1);
            this.tlpPhoneFields.Controls.Find(newPhoneTypeField.Name, true)[0].TextChanged += mmtxtPhoneType_TextChanged;

            this.tlpPhoneFields.SetRow(this.btnRemovePhoneField, childrenCount - 1);
            this.tlpPhoneFields.SetColumn(this.btnRemovePhoneField, 2);
            this.btnRemovePhoneField.Visible = true;
            this.btnRemovePhoneField.Tag = childrenCount - 1;

            for (int i = 0; i < this.tlpPhoneFields.RowCount; i++)
            {
                this.tlpPhoneFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
        }

        private MaterialMaskedTextBox CreatePhoneField(int fieldIndex, string text = "")
        {
            MaterialMaskedTextBox phoneField = new MaterialMaskedTextBox();
            phoneField.Name = "mmtxtPhone" + fieldIndex.ToString();
            phoneField.Font = this.mmtxtPrototype.Font;
            phoneField.Hint = "Teléfono " + fieldIndex.ToString();
            phoneField.Mask = "0000000000";
            phoneField.Text = text;

            return phoneField;
        }

        private MaterialMaskedTextBox CreatePhoneTypeField(int fieldIndex, string text = "")
        {
            MaterialMaskedTextBox phoneTypeField = new MaterialMaskedTextBox();
            phoneTypeField.Name = "mmtxtPhoneType" + fieldIndex.ToString();
            phoneTypeField.Font = this.mmtxtPrototype.Font;
            phoneTypeField.Hint = "Tipo de teléfono " + fieldIndex.ToString();
            phoneTypeField.Text = text;

            return phoneTypeField;
        }

        private void mmtxtPhoneField_OnFocus(object sender, EventArgs e)
        {
            var phoneField = sender as MaterialMaskedTextBox;
            phoneField.SelectionStart = phoneField.Text.Length;
        }

        private void btnRemovePhoneField_Click(object sender, EventArgs e)
        {
            var btnRemove = sender as Button;
            int rowIndex = (int)btnRemove.Tag;

            for (int i = this.tlpPhoneFields.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.tlpPhoneFields.Controls[i];

                if (this.tlpPhoneFields.GetRow(control) == rowIndex && (control.Name.StartsWith("mmtxtPhone") || control.Name.StartsWith("mmtxtPhoneType")))
                {
                    this.tlpPhoneFields.Controls.Remove(control);
                    control.Dispose();
                }
            }

            int newIndex = rowIndex - 1;
            this.tlpPhoneFields.SetRow(this.btnRemovePhoneField, newIndex);
            this.tlpPhoneFields.SetColumn(this.btnRemovePhoneField, 2);
            this.tlpPhoneFields.RowStyles.RemoveAt(rowIndex);
            this.tlpPhoneFields.RowCount--;
            this.btnRemovePhoneField.Tag = newIndex;

            this.tlpPhoneFields.SetRow(this.btnAddPhoneField, rowIndex);
            this.tlpPhoneFields.SetColumn(this.btnAddPhoneField, 0);

            if (this.tlpPhoneFields.RowCount == 1)
            {
                this.btnRemovePhoneField.Visible = false;
            }

            this.tlpPhoneFields.PerformLayout();
            this.tlpPhoneFields.ResumeLayout();
        }

        private void mmtxtPhoneType_TextChanged(object sender, EventArgs e)
        {
            var mmtxtPhoneType = sender as MaterialMaskedTextBox;

            if (mmtxtPhoneType.Text.Length > 10)
            {
                mmtxtPhoneType.Text = mmtxtPhoneType.Text.Substring(0, 10);
                mmtxtPhoneType.SelectionStart = mmtxtPhoneType.Text.Length;
            }
        }

        private void mcmbState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mcmbCity.Enabled = true;
            mcmbCity.Items.Clear();
            FillCities();
        }

        private void mmtxtExtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int charCode = (int)e.KeyChar;

            if (e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (charCode < 48 || charCode > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void mmtxtIntNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int charCode = (int)e.KeyChar;

            if (e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (charCode < 48 || charCode > 57)
                {
                    e.Handled = true;
                }
            }
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

        private void mmtxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtEmail.Text.Length > 30)
            {
                this.mmtxtEmail.Text = this.mmtxtEmail.Text.Substring(0, 30);
                this.mmtxtEmail.SelectionStart = this.mmtxtEmail.Text.Length;
            }
        }
    }
}
