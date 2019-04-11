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
    public partial class FormOrderHeader : Form
    {
        private List<int> orderLines;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int o_header_id;
        private bool finished = false;

        public FormOrderHeader()
        {
            InitializeComponent();
        }

        public FormOrderHeader(List<int> orders)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            orderLines = orders;

            o_header_id = 0;

            if (ctx.ORDER_HEADERS.Count() != 0)
            {
                var nonQuery = (from h in ctx.ORDER_HEADERS
                                select h.OH_ID).Max();
                o_header_id = nonQuery;
            }

            labelOrder.Text += (o_header_id + 1).ToString();

            iTEMSBindingSource.DataSource = ctx.ITEMS.ToList();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBox000.Text == null || comboBoxPayment.Text == null ||
                textBoxApp.Text == null || textBoxCity.Text == null ||
                textBoxEmail.Text == null || textBoxHouse.Text == null ||
                textBoxNumber.Text == null || textBoxStreet.Text == null)
                {
                    MessageBox.Show("Заповніть обов'язкові поля!");
                    return;
                }

            if(!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Недопустимий Email!");
                textBoxEmail.Text = "";
                return;
            }

            if(textBoxNumber.Text.Length != 7)
            {
                MessageBox.Show("Недопустимий номер телефону!");
                textBoxNumber.Text = "";
                comboBox000.Text = "";
                return;
            }

            finished = true;
            this.Close();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void textBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9))
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxNumber.Text = "";
            }
        }

        private void textBoxApp_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9))
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxApp.Text = "";
            }
        }

        private void FormOrderHeader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(finished == false)
            {
                var query = (from line in ctx.ORDER_LINES
                             where orderLines.Contains(line.OL_ID)
                             select line);

                foreach(var line in query)
                {
                    ctx.ORDER_LINES.Remove(line);
                }
                ctx.SaveChanges();
            }
        }
    }
}
