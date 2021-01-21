using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Lichthi
    {
        public string Doia { set; get; }
        public string Doib { set; get; }
        public string Ngaythi { set; get; }
        public string Giothi { set; get; }
        public string Santhi { set; get; }

        public Lichthi(string doia, string doib, string ngaythi, string giothi, string santhi)
        {
            Doia = doia;
            Doib = doib;
            Ngaythi = ngaythi;
            Giothi = giothi;
            Santhi = santhi;
        }
        public Lichthi() { }
    }
}
