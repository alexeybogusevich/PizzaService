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
    public partial class FormHistoryOrders : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int customer_id;
        private int user_id;

        public FormHistoryOrders(int user)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            user_id = user;

            var customer = (from c in ctx.CUSTOMERS
                            where c.C_USERID == user_id
                            select c).First();

            customer_id = customer.C_ID;

            var query = (from h in ctx.HISTORY_HEADERS
                         where h.HH_CUSTOMER == customer_id
                         select h);

            hISTORYHEADERSBindingSource.DataSource = query.ToList();
        }

        private void dataGridViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewHistory.CurrentCell.ColumnIndex == 2)
            {
                int header_id = (int)dataGridViewHistory.CurrentRow.Cells["hHIDDataGridViewTextBoxColumn"].Value;

                FormHistoryOrderSelected historyOrdersSelected = new FormHistoryOrderSelected(header_id, user_id);
                historyOrdersSelected.ShowDialog(this);
                historyOrdersSelected.Dispose();

                var query = (from h in ctx.HISTORY_HEADERS
                             where h.HH_CUSTOMER == customer_id
                             select h);

                hISTORYHEADERSBindingSource.DataSource = query.ToList();
            }
        }
    }
}
