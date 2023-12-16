using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionCivil
{
    internal class CityItem
    {
        public int Index { get; set; }
        public string Content { get; set; }

        public CityItem(int index, string content)
        {
            Index = index;
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
