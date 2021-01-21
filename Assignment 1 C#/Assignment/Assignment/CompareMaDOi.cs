using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CompareMaDoi : IComparer<Doi>
    {
        int IComparer<Doi>.Compare(Doi x, Doi y)
        {
            if (x == null || x.Madoi == null)
            {
                return -1;
            }
            if (y == null || y.Madoi == null)
            {
                return 1;
            }
            if (x.Madoi == y.Madoi)
            {
                return 0;
            }
            return x.Madoi.CompareTo(y.Madoi);
            throw new NotImplementedException();
        }
    }
}
