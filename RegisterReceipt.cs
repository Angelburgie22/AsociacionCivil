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
using Humanizer;
using System.Text.RegularExpressions;
using System.Globalization;

namespace AsociacionCivil
{
    public partial class RegisterReceipt : Form
    {
        public RegisterReceipt()
        {
            InitializeComponent();
            FillPeriods();
            FillPartners();
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FillPeriods()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM periodo";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string startDate = DateTime.Parse(reader["per_inicio"].ToString()).ToString("yyyy-MM-dd");
                        string endDate = DateTime.Parse(reader["per_fin"].ToString()).ToString("yyyy-MM-dd");
                        string content = $"{reader["per_codigo"]} - {startDate} - {endDate}";
                        PeriodItem periodItem = new PeriodItem(int.Parse(reader["per_codigo"].ToString()), content, startDate, endDate);

                        mcmbPeriods.Items.Add(periodItem);
                    }
                }
            }
        }

        private void FillPartners()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                string query = "SELECT soc_rfc, nombre, apellido_pat, apellido_mat FROM socio";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string content = $"{reader["soc_rfc"]} - {reader["nombre"]} {reader["apellido_pat"]} {reader["apellido_mat"]}";
                        PartnerItem partnerItem = new PartnerItem((string)reader["soc_rfc"], content);

                        mcmbPartners.Items.Add(partnerItem);
                    }
                }
            }
        }

        private void btnInsertNew_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Math.Round(decimal.Parse(mmtxtAmount.Text), 2);
                string invoiceNum = "";

                if (mchkAutomaticInvoiceNum.Checked == true)
                {
                    invoiceNum = GetValidInvoiceNum();
                }
                else
                {
                    invoiceNum = mmtxtInvoiceNum.Text;
                }

                if (amount >= 10000000000M)
                {
                    MessageBox.Show("Importe muy grande, no debe exceder los 9,999,999,999.", "Importe fuera del rango");
                }
                else if(!Regex.IsMatch(invoiceNum, @"^\d{6}$"))
                {
                    MessageBox.Show("El folio ingresado no es válido. El formato debe de ser de 6 números.", "Error en el folio");
                }
                else if (IsDateValid() == false)
                {
                    MessageBox.Show("La fecha del recibo no coincide con el periodo seleccionado.", "Error de fecha");
                }
                else
                {
                    CultureInfo culture = new CultureInfo("es-ES");
                    int intPart = (int)Math.Floor(amount);
                    int decimalPart = (int)((amount % 1) * 100);
                    string intText = intPart.ToWords(culture);
                    string decimalText = decimalPart.ToWords(culture);
                    string amountText = intText + " pesos con " + decimalText + " centavos";

                    PeriodItem periodSelected = (PeriodItem)mcmbPeriods.SelectedItem;
                    PartnerItem partnerSelected = (PartnerItem)mcmbPartners.SelectedItem;

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("INSERT INTO recibo(rec_folio, estatus, fecha, importe_pesos_mx, importe_letra, per_codigo, soc_rfc) VALUES (@rec_folio, @estatus, @fecha, @importe_pesos_mx, @importe_letra, @per_codigo, @soc_rfc)", connection))
                        {
                            command.Parameters.AddWithValue("rec_folio", invoiceNum);
                            command.Parameters.AddWithValue("estatus", "A");
                            command.Parameters.AddWithValue("fecha", dtpReceiptDate.Value);
                            command.Parameters.AddWithValue("importe_pesos_mx", amount);
                            command.Parameters.AddWithValue("importe_letra", amountText);
                            command.Parameters.AddWithValue("per_codigo", periodSelected.Index);
                            command.Parameters.AddWithValue("soc_rfc", partnerSelected.RFC);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Recibo creado exitosamente.", "Creación exitosa");
                        }

                        using (SqlCommand command = new SqlCommand("INSERT INTO recibo_firma(adm_id, rec_folio) VALUES (@adm_id, @rec_folio)", connection))
                        {
                            command.Parameters.AddWithValue("adm_id", Properties.Settings.Default.AdminIndex);
                            command.Parameters.AddWithValue("rec_folio", invoiceNum);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Recibo firmado exitosamente.", "Firma de recibo");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error en el intento de inserción");
            }
        }

        private string GetValidInvoiceNum()
        {
            string nextFolio = "000000";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                string query = "SELECT TOP 1 rec_folio " +
                               "FROM recibo " +
                               "ORDER BY rec_folio ASC";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string lastFolio = reader.GetString(0);

                        int nextFolioNumber = int.Parse(lastFolio) + 1;
                        nextFolio = nextFolioNumber.ToString("D6");
                    }
                }
            }

            return nextFolio;
        }

        private void mchkAutomaticInvoiceNum_CheckedChanged(object sender, EventArgs e)
        {
            if(mchkAutomaticInvoiceNum.Checked == true)
            {
                mmtxtInvoiceNum.Enabled = false;
            }
            else
            {
                mmtxtInvoiceNum.Enabled = true;
            }
        }
        private bool IsDateValid()
        {
            if (mcmbPeriods.SelectedIndex != -1)
            {
                PeriodItem periodSelected = (PeriodItem)mcmbPeriods.SelectedItem;
                int result = DateTime.Compare(DateTime.Parse(periodSelected.StartDate), dtpReceiptDate.Value);

                if (result > 0)
                {
                    return false;
                }

                int result2 = DateTime.Compare(dtpReceiptDate.Value, DateTime.Parse(periodSelected.EndDate));

                if(result2 > 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void mmtxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int charCode = (int)e.KeyChar;

            if (e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if(charCode == 46 && mmtxtAmount.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else if ((charCode < 48 && charCode != 46) || charCode > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void mcmbPeriods_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.dtpReceiptDate.Enabled = true;
        }
    }
}
