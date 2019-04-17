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
    public partial class FormHistoryLinesAdmin : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int header_id;

        public FormHistoryLinesAdmin(int header)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            header_id = header;

            var query = (from line in ctx.ORDER_LINES
                         where line.OL_ORDER_HEADER == header_id
                         select line);

            var items = (from i in ctx.ITEMS
                         select i);

            iTEMSBindingSource.DataSource = items.ToList();
            oRDERLINESBindingSource.DataSource = query.ToList();
        }

        private void dataGridViewLines_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
