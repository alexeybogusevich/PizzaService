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

        public FormActiveOrders(int user_id)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            user = user_id;

            var query = (from header in ctx.ORDER_HEADERS
                         where header.OH_CUSTOMER == user
                         select header);

            oRDERHEADERSBindingSource.DataSource = query.ToList();
        }

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int header = (int)dataGridViewOrders.CurrentRow.Cells["oHIDDataGridViewTextBoxColumn"].Value;
            FormActiveOrdersSelected selected = new FormActiveOrdersSelected(header);
            selected.ShowDialog(this);
            selected.Dispose();
        }
    }
}
