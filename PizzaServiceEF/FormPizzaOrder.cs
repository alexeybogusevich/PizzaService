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
    public partial class FormPizzaOrder : Form
    {
        private double sum = 0;
        private List<int> orderLines;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private bool finished = false;
        private int user_id;

        public FormPizzaOrder(int user)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            orderLines = new List<int>();
            user_id = user;
            
            InitializePizza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void InitializePizza()
        {
            const string categoryPizza = "Піца";
            const string categoryDrinks = "Напій";
            const string categoryDesserts = "Десерт";
            const string categorySides = "Сайди";

            var queryPizza = (from i in ctx.ITEMS
                         where (i.I_CATEGORY == categoryPizza && i.I_SIZE == "S")
                         select i).OrderBy(x=>x.I_NAME);

            var queryDrinks = (from i in ctx.ITEMS
                               where (i.I_CATEGORY == categoryDrinks)
                               select i).OrderBy(x => x.I_NAME);

            var queryDesserts = (from i in ctx.ITEMS
                                 where (i.I_CATEGORY == categoryDesserts)
                                 select i).OrderBy(x => x.I_NAME);

            var querySides = (from i in ctx.ITEMS
                                 where (i.I_CATEGORY == categorySides)
                                 select i).OrderBy(x => x.I_NAME);

            iTEMSBindingSourcePizza.DataSource = queryPizza.ToList();
            iTEMSBindingSourceDrinks.DataSource = queryDrinks.ToList();
            iTEMSBindingSourceDesserts.DataSource = queryDesserts.ToList();
            iTEMSBindingSourceSides.DataSource = querySides.ToList();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                this.Text = "Піца - замовити з доставкою | Domino's Pizza";
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                this.Text = "Напої - замовити з доставкою | Domino's Pizza";
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.Text = "Десерти - замовити з доставкою | Domino's Pizza";
            }
            else
            {
                this.Text = "Сайди - замовити з доставкою | Domino's Pizza";

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string pizzaName = dataGridViewPizza.CurrentRow.Cells["iNAMEDataGridViewTextBoxColumn"].Value.ToString();
            FormPizzaAdd formPizzaAdd = new FormPizzaAdd(pizzaName, orderLines);
            formPizzaAdd.ShowDialog(this);
            formPizzaAdd.Dispose();
            SetSumCaption();
        }

        private void SetSumCaption()
        {
            var query = (from o in ctx.ORDER_LINES
                         where orderLines.Contains(o.OL_ID)
                         select o);

            if(ctx.ORDER_LINES.Count() == 1)
            {
                query = (from o in ctx.ORDER_LINES
                         select o);
                orderLines[orderLines.Count() - 1] = query.First().OL_ID;
            }

            sum = 0;

            foreach(var line in query)
            {
                double lineSum = (double)(from i in ctx.ITEMS
                                  where line.OL_ITEM == i.I_ID
                                  select i.I_PRICE).First() * line.OL_QUANTITY;
                sum += lineSum;
            }

            buttonCart.Text = sum.ToString();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            if(orderLines.Count() == 0)
            {
                MessageBox.Show("Ви не додали жодної страви!", "Кошик");
                return;
            }
            FormCart cart = new FormCart(orderLines);
            cart.ShowDialog(this);
            cart.Dispose();
            SetSumCaption();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (orderLines.Count() == 0)
            {
                MessageBox.Show("Страви не обрано!", "Замовлення");
                return;
            }

            finished = true;

            FormOrderHeader orderHeader = new FormOrderHeader(orderLines);
            orderHeader.ShowDialog(this);
            orderHeader.Dispose();
            this.Close();
        }

        private void buttonAddDrinks_Click(object sender, EventArgs e)
        {
            int drinkId = (int)dataGridViewDrinks.CurrentRow.Cells["iIDDataGridViewTextBoxColumn1"].Value;
            FormItemAdd itemAdd = new FormItemAdd(drinkId, orderLines);
            itemAdd.ShowDialog(this);
            itemAdd.Dispose();
            SetSumCaption();
        }

        private void buttonAddDessert_Click(object sender, EventArgs e)
        {
            int drinkId = (int)dataGridViewDesserts.CurrentRow.Cells["iIDDataGridViewTextBoxColumn2"].Value;
            FormItemAdd itemAdd = new FormItemAdd(drinkId, orderLines);
            itemAdd.ShowDialog(this);
            itemAdd.Dispose();
            SetSumCaption();
        }

        private void buttonAddSide_Click(object sender, EventArgs e)
        {
            int drinkId = (int)dataGridViewSides.CurrentRow.Cells["iIDDataGridViewTextBoxColumn3"].Value;
            FormItemAdd itemAdd = new FormItemAdd(drinkId, orderLines);
            itemAdd.ShowDialog(this);
            itemAdd.Dispose();
            SetSumCaption();
        }

        private void dataGridViewPizza_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string description = dataGridViewPizza.CurrentRow.Cells["iDESCRIPTIONDataGridViewTextBoxColumn"].Value.ToString();
            description = description.Replace(';', '\n');
            description = description.Replace("\n\n", "\n");

            richTextBox1.Text = "\n\n" + description;

            int image_id = (int)dataGridViewPizza.CurrentRow.Cells["iIMAGEDataGridViewTextBoxColumn"].Value;

            var query = (from im in ctx.IMAGES
                         where im.IMG_id == image_id
                         select im.IMG_ImageData).First();

            System.IO.MemoryStream ms = new System.IO.MemoryStream(query);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox2.Image = img;

            labelPrice.Text = "від " + dataGridViewPizza.CurrentRow.Cells["iPRICEDataGridViewTextBoxColumn"].Value.ToString() + " грн.";
        }

        private void dataGridViewDrinks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int image_id = (int)dataGridViewDrinks.CurrentRow.Cells["iIMAGEDataGridViewTextBoxColumn1"].Value;

            var query = (from im in ctx.IMAGES
                         where im.IMG_id == image_id
                         select im.IMG_ImageData).First();

            System.IO.MemoryStream ms = new System.IO.MemoryStream(query);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox3.Image = img;

            labelDrinkPrice.Text = "від " + dataGridViewDrinks.CurrentRow.Cells["iPRICEDataGridViewTextBoxColumn1"].Value.ToString() + " грн.";
        }

        private void dataGridViewDesserts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int image_id = (int)dataGridViewDesserts.CurrentRow.Cells["iIMAGEDataGridViewTextBoxColumn2"].Value;

            var query = (from im in ctx.IMAGES
                         where im.IMG_id == image_id
                         select im.IMG_ImageData).First();

            System.IO.MemoryStream ms = new System.IO.MemoryStream(query);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox4.Image = img;

            labelDessertsPrice.Text = "від " + dataGridViewDesserts.CurrentRow.Cells["iPRICEDataGridViewTextBoxColumn2"].Value.ToString() + " грн.";
        }

        private void dataGridViewSides_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int image_id = (int)dataGridViewSides.CurrentRow.Cells["iIMAGEDataGridViewTextBoxColumn3"].Value;

            var query = (from im in ctx.IMAGES
                         where im.IMG_id == image_id
                         select im.IMG_ImageData).First();

            System.IO.MemoryStream ms = new System.IO.MemoryStream(query);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox5.Image = img;

            labelSidesPrice.Text = "від " + dataGridViewSides.CurrentRow.Cells["iPRICEDataGridViewTextBoxColumn3"].Value.ToString() + " грн.";
        }

        private void FormPizzaOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finished == false)
            {
                var query = (from line in ctx.ORDER_LINES
                             where orderLines.Contains(line.OL_ID)
                             select line);

                foreach (var line in query)
                {
                    ctx.ORDER_LINES.Remove(line);
                }
                ctx.SaveChanges();
            }
        }
    }
}
