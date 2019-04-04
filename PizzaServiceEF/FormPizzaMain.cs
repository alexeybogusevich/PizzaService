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
    public partial class FormPizzaService : Form
    {
        public FormPizzaService()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormPizzaOrder order = new FormPizzaOrder();
            this.Visible = false;
            order.ShowDialog(this);
            this.Visible = true;
        }
    }
}
