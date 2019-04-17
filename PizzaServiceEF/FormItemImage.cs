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
    public partial class FormItemImage : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int item_id;

        public FormItemImage(int item)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            item_id = item;

            var queryItem = (from i in ctx.ITEMS
                             where i.I_ID == item_id
                             select i).First();

            var query = (from im in ctx.IMAGES
                         where im.IMG_id == queryItem.I_IMAGE
                         select im.IMG_ImageData).First();

            System.IO.MemoryStream ms = new System.IO.MemoryStream(query);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox1.Image = img;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
