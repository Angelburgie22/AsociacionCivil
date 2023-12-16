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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            FillGrid();
        }
        SqlConnection admin = new SqlConnection(Properties.Settings.Default.ConnectionString);

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asociacioncivilDataSet.administrador' table. You can move, or remove it, as needed.
            this.administradorTableAdapter.Fill(this.asociacioncivilDataSet.administrador);
        }

        private void mbtnInsertNewAdmin_Click(object sender, EventArgs e)
        {
            RegisterAdmin frmRegisterAdmin = new RegisterAdmin();
            frmRegisterAdmin.ShowDialog();
        }
        public void FillGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from administrador", admin);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdmin.DataSource = dt;
        }

        private void mbtnUpdateAdmin_Click(object sender, EventArgs e)
        {
            string rfc = dgvAdmin.CurrentRow.Cells[1].Value.ToString();
            string name = dgvAdmin.CurrentRow.Cells[2].Value.ToString();
            string pLastName = dgvAdmin.CurrentRow.Cells[3].Value.ToString();
            string mLastName = dgvAdmin.CurrentRow.Cells[4].Value.ToString();
            string pc = dgvAdmin.CurrentRow.Cells[9].Value.ToString();
            string intNum = dgvAdmin.CurrentRow.Cells[7].Value.ToString();
            string extNum = dgvAdmin.CurrentRow.Cells[8].Value.ToString();
            string email = dgvAdmin.CurrentRow.Cells[5].Value.ToString();
            string suburb = dgvAdmin.CurrentRow.Cells[10].Value.ToString();
            string street = dgvAdmin.CurrentRow.Cells[6].Value.ToString();
            int cityIndex = (int)dgvAdmin.CurrentRow.Cells[11].Value;
            string startDate = dgvAdmin.CurrentRow.Cells[13].Value.ToString();
            string exitDate = dgvAdmin.CurrentRow.Cells[14].Value.ToString();
            string status = dgvAdmin.CurrentRow.Cells[12].Value.ToString();
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

            UpdateAdmin frmUpdateAdmin = new UpdateAdmin(rfc, name, pLastName, mLastName, pc, extNum, street, suburb, city, state, startDate, intNum, email, exitDate, status);
            frmUpdateAdmin.ShowDialog();
        }

        private void mbtnAssignUser_Click(object sender, EventArgs e)
        {
            int adminIndex = int.Parse(dgvAdmin.CurrentRow.Cells[0].Value.ToString());

            RegisterUser frmRegisterUser = new RegisterUser(adminIndex);
            frmRegisterUser.ShowDialog();
        }
    }
}
