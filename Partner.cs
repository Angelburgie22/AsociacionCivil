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
    public partial class Partner : Form
    {
        public Partner()
        {
            InitializeComponent();
            FillGrid();
        }
        public void FillGrid()
        {
            using(SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM socio", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPartner.DataSource = dt;
            }
        }

        private void Partner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asociacioncivilDataSet.socio' table. You can move, or remove it, as needed.
            this.socioTableAdapter.Fill(this.asociacioncivilDataSet.socio);
        }

        private void mbtnInsertNewPartner_Click(object sender, EventArgs e)
        {
            RegisterPartner frmRegisterPartner = new RegisterPartner();
            frmRegisterPartner.ShowDialog();
        }

        private void mbtnUpdatePartner_Click(object sender, EventArgs e)
        {
            string rfc = dgvPartner.CurrentRow.Cells[0].Value.ToString();
            string personType = dgvPartner.CurrentRow.Cells[1].Value.ToString();
            string name = dgvPartner.CurrentRow.Cells[2].Value.ToString();
            string pLastName = dgvPartner.CurrentRow.Cells[3].Value.ToString();
            string mLastName = dgvPartner.CurrentRow.Cells[4].Value.ToString();
            string email = dgvPartner.CurrentRow.Cells[5].Value.ToString();
            string street = dgvPartner.CurrentRow.Cells[6].Value.ToString();
            string intNum = dgvPartner.CurrentRow.Cells[7].Value.ToString();
            string extNum = dgvPartner.CurrentRow.Cells[8].Value.ToString();
            string pc = dgvPartner.CurrentRow.Cells[9].Value.ToString();
            string suburb = dgvPartner.CurrentRow.Cells[10].Value.ToString();
            int cityIndex = (int)dgvPartner.CurrentRow.Cells[11].Value;
            string status = dgvPartner.CurrentRow.Cells[12].Value.ToString();
            string birthDate = dgvPartner.CurrentRow.Cells[13].Value.ToString();
            string startDate = dgvPartner.CurrentRow.Cells[14].Value.ToString();
            string exitDate = dgvPartner.CurrentRow.Cells[15].Value.ToString();
            int state = 0;
            string city = "";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT nombre, estado_num FROM ciudad WHERE ciudad_id = @ciudad_id", connection);
                command.Parameters.AddWithValue("ciudad_id", cityIndex);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        city = reader["nombre"].ToString();
                        state = int.Parse(reader["estado_num"].ToString()) - 1;
                    }
                }
            }

            UpdatePartner frmUpdatePartner = new UpdatePartner(rfc, name, pLastName, mLastName, personType, pc, extNum, status, street, suburb, state, city, startDate, birthDate, intNum, email, exitDate);
            frmUpdatePartner.ShowDialog();
        }

        private void mbtnDetails_Click(object sender, EventArgs e)
        {
            string partnerRFC = dgvPartner.CurrentRow.Cells[0].Value.ToString();
            int cityIndex = (int)dgvPartner.CurrentRow.Cells[11].Value;
            string city = "";
            int stateNum = 0;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT nombre, estado_num FROM ciudad WHERE ciudad_id = @ciudad_id", connection);
                command.Parameters.AddWithValue("ciudad_id", cityIndex);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        city = reader["nombre"].ToString();
                        stateNum = int.Parse(reader["estado_num"].ToString());
                    }
                }
            }

            string state = "";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT nombre FROM estado WHERE estado_num = @estado_num", connection);
                command.Parameters.AddWithValue("estado_num", stateNum);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        state = reader["nombre"].ToString();
                    }
                }
            }

            PartnerDetails frmPartnerDetails = new PartnerDetails(partnerRFC, city, state);
            frmPartnerDetails.ShowDialog();
        }
    }
}
