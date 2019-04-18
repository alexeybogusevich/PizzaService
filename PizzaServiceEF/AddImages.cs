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
    public partial class AddImages : Form
    {
        private string filename;
        private bool done = false;
        public bool success = false;
        public int image_id;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public AddImages()
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            if(filename != null && filename != "")
            {
                done = true;
            }
            labelFile.Text = filename;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!done)
            {
                MessageBox.Show("Оберіть шлях до файлу!", "Увага");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введіть підпис зображення!");
                return;
            }
            else
            {
                ImagesLoad.SaveFileToDatabase(filename, textBox1.Text);
                labelFile.Text = "";
                textBox1.Text = "";

                try
                {
                    image_id = (from im in ctx.IMAGES
                                select im.IMG_id).Max();
                }
                catch(Exception)
                {
                    MessageBox.Show("Помилка при додаванні зображення!", "Увага");
                    return;
                }
                finally
                {
                    success = true;
                    this.Close();
                }
            }
        }
    }
}
