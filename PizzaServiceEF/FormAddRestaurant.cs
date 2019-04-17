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
    public partial class FormAddRestaurant : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public FormAddRestaurant()
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            SetTabIndexes(this);
        }

        static void SetTabIndexes(Control parent)
        {
            List<Control> list = new List<Control>(parent.Controls.Count);
            foreach (Control item in parent.Controls)
            {
                list.Add(item);
            }
            list.Sort(new ControlSorter());
            int index = 0;
            foreach (var item in list)
            {
                item.TabIndex = index;
                index++;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxAddress.Text == null || textBoxAddress.Text == "" ||
                textBoxCity.Text == null || textBoxAddress.Text == "")
            {
                MessageBox.Show("Заповнення усіх полів обов'язкове!", "Увага");
                return;
            }

            var store = new STORES
            {
                S_CITY = textBoxCity.Text,
                S_ADDRESS = textBoxAddress.Text
            };

            ctx.STORES.Add(store);
            ctx.SaveChanges();

            this.Close();
        }
    }
}
