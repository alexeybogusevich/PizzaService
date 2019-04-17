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
    public partial class FormActiveOrdersSelected : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int header_id;

        public FormActiveOrdersSelected(int header)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            header_id = header;
            this.Text += " #" + header.ToString();

            var query = (from line in ctx.ORDER_LINES
                         where line.OL_ORDER_HEADER == header_id
                         select line);

            var items = (from item in ctx.ITEMS
                         select item);

            iTEMSBindingSource.DataSource = items.ToList();
            oRDERLINESBindingSource.DataSource = query.ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string message = "Ви впевнені, що хочете відминити це замовлення?";
            string caption = "Увага!";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            var header = (from h in ctx.ORDER_HEADERS
                          where h.OH_ID == header_id
                          select h).First();

            ctx.ORDER_HEADERS.Remove(header);
            ctx.SaveChanges();

            this.Close();
        }

        private void dataGridViewOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
