using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCivil
{
    public partial class EmailDetails : Form
    {
        private GenerateReport parent;
        public EmailDetails(GenerateReport frmGenerator)
        {
            InitializeComponent();
            parent = frmGenerator;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mbtnConfirm_Click(object sender, EventArgs e)
        {
            parent.SetEmailCredentials(this.mtxtSender.Text, this.mtxtTo.Text, this.mtxtPasswdSender.Text, this.mtxtSubject.Text, this.mtxtBody.Text);
            this.Dispose();
        }
    }
}
