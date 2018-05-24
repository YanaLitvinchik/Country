using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class  Countries
    {
        public List<string> Cities { get; set; }
        public string Country { get; set; }
        public Countries(string country)
        {
            Cities = new List<string>();
            Country = country;
        }
        public void Remove(string s)
        {
                Cities.Remove(s);
        }

    }
}
