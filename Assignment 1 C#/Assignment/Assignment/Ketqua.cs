using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Ketqua
    {
        public string Doia { set; get; }
        public string Doib { set; get; }
        public string kqA { set; get; }
        public string kqB { set; get; }

        public int Thang { set; get; }
        public int Thua { set; get; }
        public int Hoa { set; get; }

        public Ketqua() { }
        public Ketqua(string doia, string doib, string kqa, string kqb)
        {
            Doia = doia;
            Doib = doib;
            kqA = kqa;
            kqB = kqb;
        }

    }
}
