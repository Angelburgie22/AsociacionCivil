using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AsociacionCivil
{
    public partial class Receipt : Form
    {
        PartnerDetail partnerSelected;
        ReceiptDetail receiptSelected;

        public Receipt()
        {
            InitializeComponent();
            partnerSelected = new PartnerDetail();
            receiptSelected = new ReceiptDetail();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asociacioncivilDataSet.recibo' table. You can move, or remove it, as needed.
            this.reciboTableAdapter.Fill(this.asociacioncivilDataSet.recibo);
        }

        private void mbtnInsertNewReceipt_Click(object sender, EventArgs e)
        {
            RegisterReceipt frmRegisterReceipt = new RegisterReceipt();
            frmRegisterReceipt.ShowDialog();
        }

        private void mbtnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport frmReport = new GenerateReport(receiptSelected);
            frmReport.ShowDialog();
        }

        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            partnerSelected.RFC = (string)dgvReceipt.CurrentRow.Cells[6].Value;
            int cityId = 1;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM socio WHERE soc_rfc = @soc_rfc", connection);
                command.Parameters.AddWithValue("soc_rfc", partnerSelected.RFC);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        partnerSelected.FullName = reader["nombre"].ToString() + " " + reader["apellido_pat"].ToString() + " " + reader["apellido_mat"].ToString();
                        partnerSelected.PC = reader["codigo_postal"].ToString();
                        partnerSelected.IntNum = (reader["num_int"] != null) ? reader["num_int"].ToString() : "";
                        partnerSelected.ExtNum = reader["num_ext"].ToString();
                        partnerSelected.Street = reader["calle"].ToString();
                        partnerSelected.Suburb = reader["colonia"].ToString();
                        cityId = int.Parse(reader["ciudad_id"].ToString());
                    }
                }
            }

            int stateNum = 1;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT nombre, estado_num FROM ciudad WHERE ciudad_id = @ciudad_id", connection);
                command.Parameters.AddWithValue("ciudad_id", cityId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stateNum = int.Parse(reader["estado_num"].ToString());
                        partnerSelected.City = reader["nombre"].ToString();
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT nombre FROM estado WHERE estado_num = @estado_num", connection);
                command.Parameters.AddWithValue("estado_num", stateNum);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        partnerSelected.State = reader["nombre"].ToString();
                    }
                }
            }

            receiptSelected.Partner = partnerSelected;

            //Folio
            receiptSelected.InvoiceNum = (string)dgvReceipt.CurrentRow.Cells[0].Value;
            //Fecha
            receiptSelected.Date = ((DateTime)dgvReceipt.CurrentRow.Cells[2].Value).ToString("yyyy-MM-dd");
            //Importe en pesos
            receiptSelected.Amount = (decimal)dgvReceipt.CurrentRow.Cells[3].Value;
            //Importe en letra
            receiptSelected.AmountText = (string)dgvReceipt.CurrentRow.Cells[4].Value;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM periodo WHERE per_codigo = @per_codigo", connection);
                command.Parameters.AddWithValue("per_codigo", int.Parse(dgvReceipt.CurrentRow.Cells[5].Value.ToString()));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        receiptSelected.Period = ((DateTime)reader["per_inicio"]).ToString("yyyy-MM-dd") + " a " + ((DateTime)reader["per_fin"]).ToString("yyyy-MM-dd");
                    }
                }
            }

            List<int> adminIndeces = new List<int>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT adm_id FROM recibo_firma WHERE rec_folio = @rec_folio", connection);
                command.Parameters.AddWithValue("rec_folio", dgvReceipt.CurrentRow.Cells[0].Value.ToString());

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        adminIndeces.Add(int.Parse(reader["adm_id"].ToString()));
                    }
                }
            }

            List<string> adminNames = new List<string>();
            Dictionary<int, string> nameByIndex = new Dictionary<int, string>();

            for(int i = 0; i < adminIndeces.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT nombre, apellido_pat, apellido_mat FROM administrador WHERE adm_id = @adm_id", connection);
                    command.Parameters.AddWithValue("adm_id", adminIndeces[i]);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["nombre"].ToString() + " " + reader["apellido_pat"].ToString() + " " + reader["apellido_mat"].ToString();
                            adminNames.Add(name);
                            nameByIndex.Add(adminIndeces[i], name);
                        }
                    }
                }
            }

            List<string> adminType = new List<string>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                for (int i = 0; i < adminIndeces.Count; i++)
                {
                    SqlCommand command = new SqlCommand("SELECT nivel_usuario FROM usuario WHERE adm_id = @adm_id", connection);
                    command.Parameters.AddWithValue("adm_id", adminIndeces[i]);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userType = reader["nivel_usuario"].ToString();

                            if(userType == "A")
                            {
                                receiptSelected.AdminAName = nameByIndex[adminIndeces[i]];
                            }
                            else
                            {
                                receiptSelected.AdminEName = nameByIndex[adminIndeces[i]];
                            }
                        }
                    }
                }
            }

            mbtnGenerateReport.Visible = true;
            mbtnUpdateReceipt.Visible = true;
        }

        private void mbtnUpdateReceipt_Click(object sender, EventArgs e)
        {
            string invoiceNum = (string)dgvReceipt.CurrentRow.Cells[0].Value;
            string status = (string)dgvReceipt.CurrentRow.Cells[1].Value;
            string date = DateTime.Parse(dgvReceipt.CurrentRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd");
            string amount = dgvReceipt.CurrentRow.Cells[3].Value.ToString();
            string amountText = (string)dgvReceipt.CurrentRow.Cells[4].Value;
            int periodCode = int.Parse(dgvReceipt.CurrentRow.Cells[5].Value.ToString());
            string partnerRFC = (string)dgvReceipt.CurrentRow.Cells[6].Value;
            string description = "";
            string motive = "";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM recibo_cancelacion WHERE rec_folio = @rec_folio", connection);
                command.Parameters.AddWithValue("rec_folio", invoiceNum);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        description = reader["descripcion_cancelacion"].ToString();
                        motive = reader["motivo"].ToString();
                    }
                }
            }

            UpdateReceipt frmUpdateReceipt = new UpdateReceipt(invoiceNum, status, date, amount, amountText, periodCode, partnerRFC, description, motive);
            frmUpdateReceipt.ShowDialog();
        }
    }
}