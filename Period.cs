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
    public partial class Period : Form
    {
        public Period()
        {
            InitializeComponent();
            FillGrid();
        }

        private void Period_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asociacioncivilDataSet.periodo' table. You can move, or remove it, as needed.
            this.periodoTableAdapter.Fill(this.asociacioncivilDataSet.periodo);
        }

        private void mbtnCreatePeriod_Click(object sender, EventArgs e)
        {
            RegisterPeriod frmRegisterPeriod = new RegisterPeriod();
            frmRegisterPeriod.ShowDialog();
        }
        public void FillGrid()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM periodo", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPeriod.DataSource = dt;
            }
        }
    }
}
