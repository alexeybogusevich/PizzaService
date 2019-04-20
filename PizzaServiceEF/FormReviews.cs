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
    public partial class FormReviews : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int customer;

        public FormReviews(int customer_id)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            customer = customer_id;

            var reviews = (from r in ctx.REVIEWS
                           select r);

            rEVIEWSBindingSource.DataSource = reviews.ToList();

            if(reviews.Count() != 0)
            {
                richTextBox1.Text = reviews.First().R_TEXT;
            }

            var customers = (from c in ctx.CUSTOMERS
                         select c);

            cUSTOMERSBindingSource.DataSource = customers.ToList();

            dataGridViewComments.ClearSelection();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormReviewAdding reviewAdding = new FormReviewAdding(customer);
            reviewAdding.ShowDialog(this);
            reviewAdding.Dispose();

            var reviews = (from r in ctx.REVIEWS
                           select r);

            rEVIEWSBindingSource.DataSource = reviews.ToList();
        }

        private void dataGridViewComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string text = dataGridViewComments.CurrentRow.Cells["rTEXTDataGridViewTextBoxColumn"].Value.ToString();

            richTextBox1.Text = text;
        }

        private void dataGridViewComments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
