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
        private double sum;

        private List<int> orderLines;

        public FormCart()
        {
            InitializeComponent();
        }

        public FormCart(List<int> orders)
        {
            InitializeComponent();

            orderLines = orders;
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();

            var query = (from o in ctx.ORDER_LINES
                         where orderLines.Contains(o.OL_ID)
                         select o);
            try
            {
                foreach (var line in query)
                {
                    var item = ctx.ITEMS.Single(a => a.I_ID == line.OL_ITEM);
                    sum += (double)item.I_PRICE * line.OL_QUANTITY;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Сталася помилка!", "Помилка");
            }

            iTEMSBindingSource.DataSource = ctx.ITEMS.ToList();
            oRDERLINESBindingSource.DataSource = query.ToList();
            dataGridViewCart.Refresh();
            labelPrice.Text = sum.ToString() + " грн.";
        }

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewCart.CurrentCell.ColumnIndex == 3)
            {
                int item_id = (int)dataGridViewCart.CurrentRow.Cells["oLITEMDataGridViewTextBoxColumn"].Value; //Other name!!
                int quantity = (int)dataGridViewCart.CurrentRow.Cells["oLQUANTITYDataGridViewTextBoxColumn"].Value;
                sum -= (double)ctx.ITEMS.Single(a => a.I_ID == item_id).I_PRICE * quantity;
                int line_id = (int)dataGridViewCart.CurrentRow.Cells["oLIDDataGridViewTextBoxColumn"].Value;
                if (dataGridViewCart.Rows.Count == 0)
                {
                    sum = 0;
                }
                labelPrice.Text = sum.ToString() + " грн.";

                var line = (from o in ctx.ORDER_LINES
                            where o.OL_ID == line_id
                            select o).First();

                ctx.ORDER_LINES.Remove(line);
                ctx.SaveChanges();
                orderLines.Remove(line_id);

                oRDERLINESBindingSource.RemoveCurrent();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewCart_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.ThrowException = false;
            //if (e.Exception.Message == "Недопустимое значение DataGridViewComboBoxCell.")
            //{
            //    object value = dataGridViewCart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //    if (!((DataGridViewComboBoxColumn)dataGridViewCart.Columns[e.ColumnIndex]).Items.Contains(value))
            //    {
            //        ((DataGridViewComboBoxColumn)dataGridViewCart.Columns[e.ColumnIndex]).Items.Add(value);
            //        e.ThrowException = false;
            //    }
            //}
        }
    }
}
