using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCivil
{
    public class ReceiptDetail
    {
        public string InvoiceNum { get; set; }
        public string Date { get; set; }
        public string Period { get; set; }
        public PartnerDetail Partner { get; set; }
        public decimal Amount { get; set; }
        public string AmountText { get; set; }
        public string AdminEName { get; set; }
        public string AdminAName { get; set; }

        public ReceiptDetail(string invoiceNum = "", string date = "", string period = "", PartnerDetail partner = null, decimal amount = 0M, string amountText = "", string adminEName = "", string adminAName = "")
        {
            InvoiceNum = invoiceNum;
            Date = date;
            Period = period;
            Partner = partner;
            Amount = amount;
            AmountText = amountText;
            AdminEName = adminEName;
            AdminAName = adminAName;
        }
    }
}
