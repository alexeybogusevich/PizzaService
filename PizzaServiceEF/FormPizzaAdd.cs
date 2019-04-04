using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using PizzaServiceDataEF;

namespace PizzaServiceEF
{
    public partial class FormPizzaAdd : Form
    {
        private string pizza;
        private int quantity = 1;
        private List<int> orderLines;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public FormPizzaAdd()
        {
            InitializeComponent();
        }

        public FormPizzaAdd(string pizzaName, List<int> orders)
        {
            InitializeComponent();
            pizza = pizzaName;
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            this.Text = pizza;
            orderLines = orders;

            var query = (from i in ctx.ITEMS
                         where (i.I_NAME == pizza)
                         select i);
            iTEMSBindingSource.DataSource = query.ToList();

            labelPrice.Text = dataGridViewSizes.Rows[0].Cells["iPRICEDataGridViewTextBoxColumn"].Value.ToString() + " грн.";
        }

        private void dataGridViewSizes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelPrice.Text = dataGridViewSizes.CurrentRow.Cells["iPRICEDataGridViewTextBoxColumn"].Value.ToString() + " грн.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (ctx.ORDER_LINES.Count() != 0)
            {
                id = (from o in ctx.ORDER_LINES
                      select o.OL_ID).Max() + 1;
            }

            var line = new ORDER_LINES
            {
                OL_ID = id,
                OL_ITEM = (int)dataGridViewSizes.CurrentRow.Cells["iIDDataGridViewTextBoxColumn"].Value,
                OL_QUANTITY = quantity
            };

            ctx.ORDER_LINES.Add(line);
            ctx.SaveChanges();

            orderLines.Add(id);

            this.Close();
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ++quantity;
            labelQuantity.Text = quantity.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(quantity != 1)
            {
                --quantity;
                labelQuantity.Text = quantity.ToString();
            }
        }
    }
}
