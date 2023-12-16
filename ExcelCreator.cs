using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace AsociacionCivil
{
    class ExcelCreator
    {
        public static bool CreateExcel(string fileName, ReceiptDetail details)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                worksheet.Cells[1, 1] = "Folio";
                worksheet.Cells[1, 2] = "Fecha";
                worksheet.Cells[1, 3] = "Periodo";
                worksheet.Cells[1, 4] = "Importe (MX)";
                worksheet.Cells[1, 5] = "Importe (letra)";
                worksheet.Cells[1, 6] = "RFC Socio";
                worksheet.Cells[1, 7] = "Nombre del socio";
                worksheet.Cells[1, 8] = "Número interior";
                worksheet.Cells[1, 9] = "Número exterior";
                worksheet.Cells[1, 10] = "Calle";
                worksheet.Cells[1, 11] = "Colonia";
                worksheet.Cells[1, 12] = "Código postal";
                worksheet.Cells[1, 13] = "Ciudad";
                worksheet.Cells[1, 14] = "Estado";
                worksheet.Cells[1, 15] = "Nombre del encargado";
                worksheet.Cells[1, 16] = "Nombre del asistente";

                for (int i = 2; i <= 4; i++)
                {
                    worksheet.Cells[i, 1] = details.InvoiceNum;
                    worksheet.Cells[i, 2] = details.Date;
                    worksheet.Cells[i, 3] = details.Period;
                    worksheet.Cells[i, 4] = details.Amount;
                    worksheet.Cells[i, 5] = details.AmountText;
                    worksheet.Cells[i, 6] = details.Partner.RFC;
                    worksheet.Cells[i, 7] = details.Partner.FullName;
                    worksheet.Cells[i, 8] = details.Partner.IntNum;
                    worksheet.Cells[i, 9] = details.Partner.ExtNum;
                    worksheet.Cells[i, 10] = details.Partner.Street;
                    worksheet.Cells[i, 11] = details.Partner.Suburb;
                    worksheet.Cells[i, 12] = details.Partner.PC;
                    worksheet.Cells[i, 13] = details.Partner.City;
                    worksheet.Cells[i, 14] = details.Partner.State;
                    worksheet.Cells[i, 15] = details.AdminEName;
                    worksheet.Cells[i, 16] = details.AdminAName;
                }

                workbook.SaveAs(fileName);
                workbook.Close();
                excelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
