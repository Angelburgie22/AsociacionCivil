using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsociacionCivil
{
    public partial class GenerateReport : Form
    {
        private EmailCredentials emailDetails;
        private ReceiptDetail receiptDetails;
        public GenerateReport(ReceiptDetail details)
        {
            InitializeComponent();
            GetReceipt(details);
            this.Activated += GenerateReport_Activated;
            this.receiptDetails = details;
        }

        private void GetReceipt(ReceiptDetail details)
        {
            ReceiptReport frmReceipt = new ReceiptReport(details) { TopLevel = false, TopMost = true };
            frmReceipt.FormBorderStyle = FormBorderStyle.None;

            this.pnlReceiptLoader.Controls.Add(frmReceipt);
            this.pnlReceiptLoader.Size = frmReceipt.Size;
            this.Width = frmReceipt.Width;

            frmReceipt.Show();
        }

        private void mbtnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (cmbOrientation.SelectedItem != null && IsFileNameValid(mtxtFileName.Text))
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string pathFile = fbd.SelectedPath + "\\" + mtxtFileName.Text + ".pdf";

                        if(GeneratePDF.GenerateReceiptInPDF(CaptureReceipt(), cmbOrientation.SelectedItem.ToString(), pathFile))
                        {
                            MessageBox.Show("PDF generado con éxito.", "Creación exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al generar un PDF.", "Creación fallida");
                        }
                    }
                }
            }
        }
        private bool IsFileNameValid(string fileName)
        {
            bool isValid = !string.IsNullOrEmpty(fileName) && fileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;

            return isValid;
        }

        private Bitmap CaptureReceipt()
        {
            Bitmap bitmap = new Bitmap(this.pnlReceiptLoader.Width, this.pnlReceiptLoader.Height);

            this.pnlReceiptLoader.DrawToBitmap(bitmap, new Rectangle(Point.Empty, this.pnlReceiptLoader.Size));

            return bitmap;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SetEmailCredentials(string sender, string to, string passwd, string subject, string body)
        {
            emailDetails = new EmailCredentials(sender, to, passwd, subject, body);
        }

        private void GenerateReport_Activated(object sender, EventArgs e)
        {
            if (emailDetails != null)
            {
                if(GeneratePDF.GenerateReceiptInPDF(CaptureReceipt(), cmbOrientation.SelectedItem.ToString(), isAttachement: true, emailDetails: emailDetails))
                {
                    MessageBox.Show("Correo enviado con éxito.", "Correo exitoso");
                }
                else
                {
                    MessageBox.Show("El correo no pudo ser enviado.", "Correo fallido");
                }
            }

            emailDetails = null;
        }

        private void mbtnSendEmail_Click(object sender, EventArgs e)
        {
            EmailDetails frmEmailDetails = new EmailDetails(this);
            frmEmailDetails.ShowDialog();
        }

        private void mbtnCreateExcel_Click(object sender, EventArgs e)
        {
            if (IsFileNameValid(mtxtFileName.Text))
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string pathFile = fbd.SelectedPath + "\\" + mtxtFileName.Text + ".xlsx";

                        if (ExcelCreator.CreateExcel(pathFile, receiptDetails))
                        {
                            MessageBox.Show("Excel generado con éxito.", "Creación exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al generar el excel.", "Creación fallida");
                        }
                    }
                }
            }
        }
    }
}
