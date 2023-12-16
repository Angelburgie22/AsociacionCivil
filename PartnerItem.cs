using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCivil
{
    class PartnerItem
    {
        public string RFC { get; set; }
        public string Content { get; set; }

        public PartnerItem(string rfc, string content)
        {
            RFC = rfc;
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
