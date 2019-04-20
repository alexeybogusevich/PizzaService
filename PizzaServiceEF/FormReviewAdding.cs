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
    public partial class FormReviewAdding : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int customer_id;

        public FormReviewAdding(int customer)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            customer_id = customer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != null && richTextBox1.Text != "")
            {
                var review = new REVIEWS
                {
                    R_DATE = System.DateTime.Now,
                    R_CUSTOMERID = customer_id,
                    R_TEXT = richTextBox1.Text
                };

                ctx.REVIEWS.Add(review);
                ctx.SaveChanges();

                this.Close();
            }
            else
            {
                MessageBox.Show("Порожній відгук не буде опубліковано!", "Увага");
                return;
            }
        }
    }
}
