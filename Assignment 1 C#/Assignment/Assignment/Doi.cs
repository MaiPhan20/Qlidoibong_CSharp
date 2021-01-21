using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Doi : IComparable<Doi>
    {
        public string Madoi { set; get; }
        public string Tendoi { set; get; }
        public string HLV { set; get; }


        public Doi(string madoi, string tendoi, string hlv)
        {
            Madoi = madoi;
            Tendoi = tendoi;
            HLV = hlv;
        }

        public Doi() { }
        int IComparable<Doi>.CompareTo(Doi tother)
        {
            throw new NotImplementedException();
        }

    }
}
