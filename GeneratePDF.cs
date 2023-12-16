using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace AsociacionCivil
{
    class GeneratePDF
    {
        public static bool GenerateReceiptInPDF(Bitmap bmpReceipt, string orientation, string fileName = "", bool isAttachement = false, EmailCredentials emailDetails = null)
        {
            try
            {
                PdfDocument document = GeneratePDF.CreatePDF(fileName, bmpReceipt, orientation);

                if(isAttachement == false)
                {
                    document.Save(fileName);
                }
                else
                {
                    bool result = EmailSender.SendPDFToEmail(emailDetails, document);

                    return result;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private static PdfDocument CreatePDF(string fileName, Bitmap bmpReceipt, string orientation)
        {
            try
            {
                PdfDocument receiptDoc = new PdfDocument();

                MemoryStream ms = new MemoryStream();

                bmpReceipt.Save(ms, ImageFormat.Jpeg);

                XImage receipt = XImage.FromStream(ms);

                double margin = 25.4;

                double widthBlock = receipt.PointWidth;

                double heightBlock = receipt.PointHeight;

                if (orientation == "Vertical")
                {
                    PdfPage receiptPage = receiptDoc.AddPage();

                    receiptPage.Orientation = PdfSharp.PageOrientation.Portrait;

                    XGraphics gfx = XGraphics.FromPdfPage(receiptPage);

                    gfx.DrawImage(receipt, margin, margin);

                    gfx.DrawImage(receipt, margin + widthBlock, margin);

                    gfx.DrawImage(receipt, margin, margin + heightBlock);
                }
                else
                {
                    PdfPage receiptPage1 = receiptDoc.AddPage();

                    receiptPage1.Orientation = PdfSharp.PageOrientation.Landscape;

                    XGraphics gfx1 = XGraphics.FromPdfPage(receiptPage1);


                    gfx1.DrawImage(receipt, margin, margin);

                    gfx1.DrawImage(receipt, margin + widthBlock, margin);

                    PdfPage receiptPage2 = receiptDoc.AddPage();

                    receiptPage2.Orientation = PdfSharp.PageOrientation.Landscape;

                    XGraphics gfx2 = XGraphics.FromPdfPage(receiptPage2);

                    gfx2.DrawImage(receipt, margin, margin);
                }

                return receiptDoc;
            }
            catch
            {
                return null;
            }
        }
    }
}
