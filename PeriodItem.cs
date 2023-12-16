using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCivil
{
    class PeriodItem
    {
        public int Index { get; set; }
        public string Content { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public PeriodItem(int index, string content, string startDate, string endDate)
        {
            Index = index;
            Content = content;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
