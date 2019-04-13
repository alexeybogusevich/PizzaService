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
    public partial class FormActiveOrdersSelected : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int header_id;

        public FormActiveOrdersSelected(int header)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            header_id = header;
            this.Text += " #" + header.ToString();

            var query = (from line in ctx.ORDER_LINES
                         where line.OL_ORDER_HEADER == header_id
                         select line);

            oRDERLINESBindingSource.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
