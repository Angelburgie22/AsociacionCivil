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
using MaterialSkin;
using MaterialSkin.Controls;

namespace AsociacionCivil
{
    public partial class PartnerDetails : Form
    {
        public PartnerDetails(string partnerRFC, string city, string state)
        {
            InitializeComponent();
            this.mmtxtRFC.Text = partnerRFC;
            this.mmtxtCity.Text = city;
            this.mmtxtState.Text = state;
            FillPhoneFields(partnerRFC);
        }

        private void mbtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

            this.tlpPhoneFields.Controls.Add(newPhoneField);
            this.tlpPhoneFields.SetRow(newPhoneField, childrenCount - 1);
            this.tlpPhoneFields.SetColumn(newPhoneField, 0);

            this.tlpPhoneFields.Controls.Add(newPhoneTypeField);
            this.tlpPhoneFields.SetRow(newPhoneTypeField, childrenCount - 1);
            this.tlpPhoneFields.SetColumn(newPhoneTypeField, 1);

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
            phoneField.Enabled = false;

            return phoneField;
        }

        private MaterialMaskedTextBox CreatePhoneTypeField(int fieldIndex, string text = "")
        {
            MaterialMaskedTextBox phoneTypeField = new MaterialMaskedTextBox();
            phoneTypeField.Name = "mmtxtPhoneType" + fieldIndex.ToString();
            phoneTypeField.Font = this.mmtxtPrototype.Font;
            phoneTypeField.Hint = "Tipo de teléfono " + fieldIndex.ToString();
            phoneTypeField.Text = text;
            phoneTypeField.Enabled = false;

            return phoneTypeField;
        }
        private void FillPhoneFields(string partnerRFC)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT tel_numero_telefono, tel_tipo FROM telefono WHERE soc_rfc = @soc_rfc", connection);
                command.Parameters.AddWithValue("soc_rfc", partnerRFC);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AddPhoneField(reader["tel_numero_telefono"].ToString(), reader["tel_tipo"].ToString());
                    }
                }
            }
        }
    }
}
