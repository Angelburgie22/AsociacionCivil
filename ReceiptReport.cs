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
    public partial class ReceiptReport : Form
    {
        public ReceiptReport(ReceiptDetail details)
        {
            InitializeComponent();
            FillReceiptDetails(details);
        }

        private void FillReceiptDetails(ReceiptDetail details)
        {
            //Detalles del recibo
            this.lblInvoiceNum.Text = details.InvoiceNum;
            this.lblDateReceipt.Text = details.Date;
            this.lblPeriod.Text = details.Period;

            this.lblAmountMX.Text = "$" + (Math.Round(details.Amount, 2)).ToString();
            this.lblAmountText.Text = details.AmountText;

            //Detalles del recibo
            this.lblName.Text = details.Partner.FullName;
            
            if(details.Partner.IntNum != "")
            {
                this.lblAddress1.Text += details.Partner.IntNum + ", ";
            }

            this.lblAddress1.Text += details.Partner.Street;
            this.lblAddress1.Text += details.Partner.ExtNum;

            this.lblAddress2.Text += details.Partner.Suburb;
            this.lblAddress2.Text += ", C.P. " + details.Partner.PC;

            this.lblAddress3.Text += details.Partner.City + ", " + details.Partner.State;

            //Detalles de los administradores
            this.lblAdminEName.Text = details.AdminEName;
            this.lblAdminAName.Text = details.AdminAName;
        }
    }
}
