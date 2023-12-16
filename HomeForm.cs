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
    public partial class HomeForm : Form
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
        public HomeForm(LoginForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlSelection.Height = btnReceipt.Height;
            pnlSelection.Top = btnReceipt.Top;
            pnlSelection.Left = btnReceipt.Left;
            btnReceipt.BackColor = Color.FromArgb(46, 51, 73);
            this.lblUsername.Text = Properties.Settings.Default.UserName;

            this.pnlFormLoader.Controls.Clear();
            Receipt frmReceipt = new Receipt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReceipt.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmReceipt);
            frmReceipt.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

            this.pnlFormLoader.Controls.Clear();
            Receipt frmReceipt = new Receipt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReceipt.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmReceipt);
            frmReceipt.Show();
        }

        private void btnPartner_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnPartner.Height;
            pnlSelection.Top = btnPartner.Top;
            btnPartner.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Socios";

            this.pnlFormLoader.Controls.Clear();
            Partner frmPartner = new Partner() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            frmPartner.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmPartner);
            frmPartner.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnAdmin.Height;
            pnlSelection.Top = btnAdmin.Top;
            btnAdmin.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Administradores";

            this.pnlFormLoader.Controls.Clear();
            Admin frmAdmin = new Admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAdmin.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAdmin);
            frmAdmin.Show();
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            pnlSelection.Height = btnPeriod.Height;
            pnlSelection.Top = btnPeriod.Top;
            btnPeriod.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Periodos";

            this.pnlFormLoader.Controls.Clear();
            Period frmPeriod = new Period() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPeriod.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmPeriod);
            frmPeriod.Show();
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
    }
}
