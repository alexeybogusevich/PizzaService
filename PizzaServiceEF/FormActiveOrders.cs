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
    public partial class FormActiveOrders : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int user;
        private int customer_id;

        public FormActiveOrders(int user_id)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            user = user_id;

            var customer = (from c in ctx.CUSTOMERS
                         where c.C_USERID == user
                         select c).First();

            customer_id = customer.C_ID;

            var query = (from header in ctx.ORDER_HEADERS
                         where header.OH_CUSTOMER == customer_id
                         select header);

            var restaurants = (from r in ctx.STORES
                               select r);

            sTORESBindingSource.DataSource = restaurants.ToList();
            oRDERHEADERSBindingSource.DataSource = query.ToList();
        }

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int header = (int)dataGridViewOrders.CurrentRow.Cells["oHIDDataGridViewTextBoxColumn"].Value;
            FormActiveOrdersSelected selected = new FormActiveOrdersSelected(header);
            selected.ShowDialog(this);
            selected.Dispose();

            var query = (from h in ctx.ORDER_HEADERS
                         where h.OH_CUSTOMER == customer_id
                         select h);

            oRDERHEADERSBindingSource.DataSource = query.ToList();
        }
    }
}
