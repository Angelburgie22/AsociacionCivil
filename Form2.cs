using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AsociacionCivil
{

    //Data Source=DESKTOP-NB2HK07\SQL2022;Initial Catalog=asociacioncivil;Integrated Security=True
    public partial class Form2 : Form
    {
        private LoginForm parent;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRigthRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form2(LoginForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlSelection.Height = btnReceipt.Height;
            pnlSelection.Top = btnReceipt.Top;
            pnlSelection.Left = btnReceipt.Left;
            btnReceipt.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asociacioncivilDataSet.recibo' table. You can move, or remove it, as needed.
            this.reciboTableAdapter.Fill(this.asociacioncivilDataSet.recibo);
            // TODO: This line of code loads data into the 'asociacioncivilDataSet.recibo' table. You can move, or remove it, as needed.
            this.reciboTableAdapter.Fill(this.asociacioncivilDataSet.recibo);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnReceipt.Height;
            pnlSelection.Top = btnReceipt.Top;
            pnlSelection.Left = btnReceipt.Left;
            btnReceipt.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Recibos";
        }

        private void btnPartner_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnPartner.Height;
            pnlSelection.Top = btnPartner.Top;
            btnPartner.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Socios";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnAdmin.Height;
            pnlSelection.Top = btnAdmin.Top;
            btnAdmin.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Administradores";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnSettings.Height;
            pnlSelection.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Configuración";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnLogout.Height;
            pnlSelection.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);

            parent.Show();
            this.Dispose();
        }

        private void btnReceipt_Leave(object sender, EventArgs e)
        {
            btnReceipt.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPartner_Leave(object sender, EventArgs e)
        {
            btnPartner.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAdmin_Leave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
