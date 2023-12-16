using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCivil
{
    public class PartnerDetail
    {
        public string RFC { get; set; }
        public string FullName { get; set; }
        public string ExtNum { get; set; }
        public string IntNum { get; set; }
        public string Street { get; set; }
        public string PC { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public PartnerDetail(string rfc = "", string fullName = "", string extNum = "", string intNum = "", string street = "", string pc = "", string suburb = "", string city = "", string state = "")
        {
            RFC = rfc;
            FullName = fullName;
            ExtNum = extNum;
            IntNum = intNum;
            Street = street;
            PC = pc;
            Suburb = suburb;
            City = city;
            State = state;
        }
    }
}