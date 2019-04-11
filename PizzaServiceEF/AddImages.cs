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

        public AddImages()
        {
            InitializeComponent();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            labelFile.Text = filename;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Введіть підпис зображення!");
            }
            else
            {
                ImagesLoad.SaveFileToDatabase(filename, textBox1.Text);
                labelFile.Text = "";
                textBox1.Text = "";
            }
        }
    }
}
