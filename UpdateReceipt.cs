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
    public partial class UpdateReceipt : Form
    {
        public UpdateReceipt(string invoiceNum, string status, string date, string amount, string amountText, int periodCode, string partnerRFC, string description = "", string motive = "")
        {
            InitializeComponent();
            FillPeriods();
            FillPartners();

            this.mmtxtInvoiceNum.Text = invoiceNum;
            
            if(status == "A")
            {
                this.mrbActive.Checked = true;
                this.pnlCancelation.Visible = false;
            }
            else
            {
                this.mrbCanceled.Checked = true;
                this.pnlCancelation.Visible = true;
                this.mmtxtDescription.Text = description;
            }

            this.dtpReceiptDate.Value = DateTime.Parse(date);
            this.mmtxtAmount.Text = amount;

            this.mcmbPeriods.SelectedIndex = this.mcmbPeriods.FindString(periodCode.ToString());
            this.mcmbPartners.SelectedIndex = this.mcmbPartners.FindString(partnerRFC);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Math.Round(decimal.Parse(mmtxtAmount.Text), 2);

                if (amount >= 10000000000M)
                {
                    MessageBox.Show("Importe muy grande, no debe exceder los 9,999,999,999.", "Importe fuera del rango");
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

                    string status = (mrbActive.Checked == true) ? "A" : "C";

                    PeriodItem periodSelected = (PeriodItem)mcmbPeriods.SelectedItem;
                    PartnerItem partnerSelected = (PartnerItem)mcmbPartners.SelectedItem;

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("UPDATE recibo SET estatus = @estatus, fecha = @fecha, importe_pesos_mx = @importe_pesos_mx, importe_letra = @importe_letra, per_codigo = @per_codigo, soc_rfc = @soc_rfc WHERE rec_folio = @rec_folio", connection))
                        {
                            command.Parameters.AddWithValue("estatus", status);
                            command.Parameters.AddWithValue("fecha", dtpReceiptDate.Value);
                            command.Parameters.AddWithValue("importe_pesos_mx", amount);
                            command.Parameters.AddWithValue("importe_letra", amountText);
                            command.Parameters.AddWithValue("per_codigo", periodSelected.Index);
                            command.Parameters.AddWithValue("soc_rfc", partnerSelected.RFC);
                            command.Parameters.AddWithValue("rec_folio", mmtxtInvoiceNum.Text);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Recibo creado exitosamente.", "Creación exitosa");
                        }
                    }


                    if(status == "C")
                    {
                        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                        {
                            connection.Open();

                            SqlCommand command = new SqlCommand("SELECT * FROM recibo_cancelacion WHERE rec_folio = @rec_folio", connection);
                            command.Parameters.AddWithValue("rec_folio", mmtxtInvoiceNum.Text);

                            bool cancelationExists = false;

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    cancelationExists = true;
                                }
                            }

                            string query = "";

                            if (cancelationExists)
                            {
                                query = "UPDATE recibo_cancelacion SET fecha_cancelacion = @fecha_cancelacion, motivo = @motivo, descripcion_cancelacion = @descripcion_cancelacion, adm_id = @adm_id WHERE rec_folio = @rec_folio";
                            }
                            else
                            {
                                query = "INSERT INTO recibo_cancelacion(rec_folio, fecha_cancelacion, motivo, descripcion_cancelacion, adm_id) VALUES (@rec_folio, @fecha_descripcion, @motivo, @descripcion_cancelacion, @adm_id)";
                            }

                            using (SqlCommand command2 = new SqlCommand(query, connection))
                            {
                                command2.Parameters.AddWithValue("fecha_cancelacion", DateTime.Now.ToString("yyyy-MM-dd"));
                                command2.Parameters.AddWithValue("motivo", "C" + (this.mcmbMotive.SelectedIndex + 1));
                                command2.Parameters.AddWithValue("descripcion_cancelacion", this.mmtxtDescription.Text);
                                command2.Parameters.AddWithValue("adm_id", Properties.Settings.Default.AdminIndex);
                                command2.Parameters.AddWithValue("rec_folio", mmtxtInvoiceNum.Text);

                                command2.ExecuteNonQuery();

                                if (cancelationExists)
                                {
                                    MessageBox.Show("Actualización de la cancelación del recibo exitosa.", "Cancelación modificada");
                                }
                                else
                                {
                                    MessageBox.Show("Creación de la cancelación del recibo exitosa.", "Cancelación creada+");
                                }
                            }
                        }
                    }
                    else
                    {
                        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                        {
                            connection.Open();

                            SqlCommand command = new SqlCommand("SELECT * FROM recibo_cancelacion WHERE rec_folio = @rec_folio", connection);
                            command.Parameters.AddWithValue("rec_folio", mmtxtInvoiceNum.Text);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    using (SqlCommand command2 = new SqlCommand("DELETE FROM recibo_cancelacion WHERE rec_folio = @rec_folio", connection))
                                    {
                                        command2.Parameters.AddWithValue("rec_folio", mmtxtInvoiceNum.Text);

                                        command2.ExecuteNonQuery();

                                        MessageBox.Show("Se ha eliminado la cancelación del recbio.", "Cancelación eliminada");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error en el intento de inserción");
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

                if (result2 > 0)
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
                if (charCode == 46 && mmtxtAmount.Text.Contains("."))
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

        private void mmtxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (this.mmtxtDescription.Text.Length > 60)
            {
                this.mmtxtDescription.Text = this.mmtxtDescription.Text.Substring(0, 60);
                this.mmtxtDescription.SelectionStart = this.mmtxtDescription.Text.Length;
            }
        }

        private void mrbActive_CheckedChanged(object sender, EventArgs e)
        {
            if(mrbActive.Checked == true)
            {
                this.pnlCancelation.Visible = false;
            }
        }

        private void mrbCanceled_CheckedChanged(object sender, EventArgs e)
        {
            if(mrbCanceled.Checked == true)
            {
                this.pnlCancelation.Visible = true;
            }
        }
    }
}
