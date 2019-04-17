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
    public partial class FormItemAdd : Form
    {
        private int item_id;
        private double price;
        private double sumPrice;
        private string name;
        private int quantity = 1;
        private List<int> orderLines;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public FormItemAdd()
        {
            InitializeComponent();
        }

        public FormItemAdd(int id, List<int> orders)
        {
            InitializeComponent();

            orderLines = orders;
            item_id = id;
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();

            var item = (from i in ctx.ITEMS
                        where i.I_ID == item_id
                        select i).First();

            name = item.I_NAME;
            price = (double)item.I_PRICE;
            sumPrice = price * quantity;

            this.Text = name;
            labelPrice.Text = "Усього: " + sumPrice.ToString() + " грн.";
            labelName.Text = name;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            var line = new ORDER_LINES
            {
                OL_ITEM = item_id,
                OL_QUANTITY = quantity
            };

            ctx.ORDER_LINES.Add(line);
            ctx.SaveChanges();

            orderLines.Add(line.OL_ID);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(quantity > 1)
            {
                --quantity;
                labelQuantity.Text = quantity.ToString();
                sumPrice -= price;
                labelPrice.Text = "Усього: " + sumPrice.ToString() + " грн.";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ++quantity;
            labelQuantity.Text = quantity.ToString();
            sumPrice += price;
            labelPrice.Text = "Усього: " + sumPrice.ToString() + " грн.";
        }
    }
}
