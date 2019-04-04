using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaServiceEF
{
    public partial class FormCart : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private List<int> orderLines;

        public FormCart()
        {
            InitializeComponent();
        }
        
        public FormCart(List<int> orders)
        {
            orderLines = orders;
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();

            var query = (from o in ctx.ORDER_LINES
                         where orderLines.Contains(o.OL_ID)
                         select o);

            oRDERLINESBindingSource.DataSource = query.ToList();
        }
    }
}
