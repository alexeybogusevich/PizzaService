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
    public partial class FormSearchItems : Form
    {
        public string category;
        public string ingerdients;
        public int price;

        public FormSearchItems()
        {
            InitializeComponent();
            price = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxCategory.Text != null && comboBoxCategory.Text != "")
            {
                category = comboBoxCategory.Text;
            }

            if(textBoxIngredients.Text != null && textBoxIngredients.Text != "")
            {
                ingerdients = textBoxIngredients.Text;
            }

            if(textBoxPrice.Text != "" && textBoxPrice.Text != null)
            {
                price = Convert.ToInt32(textBoxPrice.Text);
            }

            this.Close();
        }

        private void textBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                && e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Tab)
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxPrice.Text = "";
            }
        }
    }
}
