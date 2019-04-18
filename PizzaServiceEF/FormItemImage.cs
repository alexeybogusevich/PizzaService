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
        private int old_image_id;
        private int image_id;

        public FormItemImage(int item)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            item_id = item;

            var queryItem = (from i in ctx.ITEMS
                             where i.I_ID == item_id
                             select i).First();

            this.Text = queryItem.I_NAME;
            if(queryItem.I_IMAGE != null)
            {
                old_image_id = (int)queryItem.I_IMAGE;
            }
            else
            {
                MessageBox.Show("Помилка додавання зображення!", "Увага");
                return;
            }

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
            AddImages addImages = new AddImages();
            addImages.ShowDialog(this);

            if(!addImages.success)
            {
                addImages.Dispose();
                return;
            }

            image_id = addImages.image_id;
            addImages.Dispose();

            var item = (from i in ctx.ITEMS
                        where i.I_ID == item_id
                        select i).First();

            item.I_IMAGE = image_id;
            ctx.SaveChanges();

            var picture = (from im in ctx.IMAGES
                           where im.IMG_id == image_id
                           select im.IMG_ImageData).First();

            System.IO.MemoryStream ms = new System.IO.MemoryStream(picture);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox1.Image = img;

            var old_image = (from im in ctx.IMAGES
                             where im.IMG_id == old_image_id
                             select im).First();

            ctx.IMAGES.Remove(old_image);
            ctx.SaveChanges();

            old_image_id = image_id;
        }
    }
}
