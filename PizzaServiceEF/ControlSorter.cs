using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaServiceEF
{
    internal class ControlSorter : IComparer<Control>
    {
        public int Compare(Control x, Control y)
        {
            int res = x.Top.CompareTo(y.Top);
            if (res == 0)
                res = x.Left.CompareTo(y.Left);
            return res;
        }
    }
}
