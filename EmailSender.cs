using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using PdfSharp.Pdf;
using System.IO;
using System.Windows.Forms;

namespace AsociacionCivil
{
    class EmailSender
    {
        public static bool SendPDFToEmail(EmailCredentials details, PdfDocument document)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    document.Save(ms);
                    byte[] pdfBytes = ms.ToArray();

                    using (MemoryStream pdfMemoryStream = new MemoryStream(pdfBytes))
                    {
                        Attachment attachment = new Attachment(pdfMemoryStream, "recibo.pdf", "application/pdf");
                        MailMessage mensaje = new MailMessage();
                        mensaje.From = new MailAddress(details.Sender);
                        mensaje.To.Add(details.To);
                        mensaje.Subject = details.Subject;
                        mensaje.Body = details.Body;
                        mensaje.Attachments.Add(attachment);

                        SmtpClient clienteSmtp = new SmtpClient("smtp-mail.outlook.com", 587);
                        clienteSmtp.Credentials = new NetworkCredential(details.Sender, details.Password);
                        clienteSmtp.EnableSsl = true;

                        clienteSmtp.Send(mensaje);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
