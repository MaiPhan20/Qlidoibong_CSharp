using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CompareTenDoi : IComparer<Doi>
    {
        int IComparer<Doi>.Compare(Doi x, Doi y)
        {
            if (x == null || x.Tendoi == null)
            {
                return -1;
            }
            if (y == null || y.Tendoi == null)
            {
                return 1;
            }
            if (x.Tendoi == y.Tendoi)
            {
                return 0;
            }
            return x.Tendoi.CompareTo(y.Tendoi);
            throw new NotImplementedException();
        }
    }
}
