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
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public FormPizzaOrder()
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            //iTEMSBindingSourcePizza.DataSource = ctx.ITEMS.Local.ToBindingList();

            InitializePizza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void InitializePizza()
        {
            const string category = "Піца";
            var query = (from i in ctx.ITEMS
                         where (i.I_CATEGORY == category && i.I_SIZE == "S")
                         select i);
            iTEMSBindingSourcePizza.DataSource = query.ToList();
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
            FormPizzaAdd formPizzaAdd = new FormPizzaAdd(pizzaName);
            formPizzaAdd.ShowDialog(this);
            formPizzaAdd.Dispose();
        }
    }
}
