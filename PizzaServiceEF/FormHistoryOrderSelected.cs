using PizzaServiceDataEF;
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
    public partial class FormHistoryOrderSelected : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int history_header;
        private int user_id;

        public FormHistoryOrderSelected(int header, int user)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            history_header = header;
            user_id = user;

            var query = (from line in ctx.HISTORY_LINES
                         where line.HL_ORDER_HEADER == history_header
                         select line);

            var items = (from i in ctx.ITEMS
                         select i);

            iTEMSBindingSource.DataSource = items.ToList();
            hISTORYLINESBindingSource.DataSource = query.ToList();
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            List<int> orderLines = new List<int>();
            double sum = 0;

            var lines = (from line in ctx.HISTORY_LINES
                         where line.HL_ORDER_HEADER == history_header
                         select line).ToList();

            foreach(var line in lines)
            {
                var x = new ORDER_LINES
                {
                    OL_ITEM = line.HL_ITEM,
                    OL_QUANTITY = line.HL_QUANTITY
                };

                var item = (from i in ctx.ITEMS
                            where i.I_ID == x.OL_ITEM
                            select i).First();

                sum += (double)item.I_PRICE * x.OL_QUANTITY;

                orderLines.Add(x.OL_ID);

                ctx.ORDER_LINES.Add(x);
                ctx.SaveChanges();
            }

            FormOrderHeader orderHeader = new FormOrderHeader(orderLines, user_id, sum);
            orderHeader.ShowDialog(this);
            orderHeader.Dispose();
            this.Close();
        }

        private void dataGridViewHistoryLines_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
