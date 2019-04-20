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
    public partial class FormOrderHeader : Form
    {
        private List<int> orderLines;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int o_header_id;
        private bool finished = false;
        private int user;
        private double sum;

        public FormOrderHeader()
        {
            InitializeComponent();
        }

        public FormOrderHeader(List<int> orders, int user_id, double s)
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            orderLines = orders;
            user = user_id;
            sum = s;

            o_header_id = 0;

            if (ctx.ORDER_HEADERS.Count() != 0)
            {
                var nonQuery = (from h in ctx.ORDER_HEADERS
                                select h.OH_ID).Max();
                o_header_id = nonQuery;
            }

            labelOrder.Text += (o_header_id + 1).ToString();

            iTEMSBindingSource.DataSource = ctx.ITEMS.ToList();

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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxPayment.Text == null || textBoxHouse.Text == null ||
                textBoxApp.Text == null || textBoxCity.Text == null ||
                textBoxHouse.Text == "" || textBoxCity.Text == "" ||
                textBoxApp.Text == "" || comboBoxPayment.Text == "")
                {
                    MessageBox.Show("Заповніть обов'язкові поля!");
                    return;
                }

            var cityPresence = (from c in ctx.STORES
                                where c.S_CITY.Equals(textBoxCity.Text.Trim())
                                select c).Count();

            if (cityPresence == 0)
            {
                MessageBox.Show("На жаль, доставка Dominos в місто " + textBoxCity.Text + " неможлива!");
                return;
            }


            var customer = (from c in ctx.CUSTOMERS
                            where c.C_USERID == user
                            select c).First();

            var header = new ORDER_HEADERS
            {
                OH_CUSTOMER = customer.C_ID,
                OH_ADDRESS = textBoxCity.Text + ", вул. " + textBoxStreet.Text + " " + textBoxHouse.Text + " кв." + textBoxApp.Text,
                OH_STORE = 1, //////////////////////////////////////////////////////////////////////////
                OH_DATE = System.DateTime.Now,
                OH_SUM = sum
            };

            var history_header = new HISTORY_HEADERS
            {
                HH_DATE = System.DateTime.Now,
                HH_PAYMENT_TYPE = comboBoxPayment.Text,
                HH_CUSTOMER = header.OH_CUSTOMER
            };

            if (comboBoxPayment.Text.Equals("Карткою онлайн"))
            {
                FormTransaction transaction = new FormTransaction(sum);
                transaction.ShowDialog(this);
                if (transaction.finished)
                {
                    history_header.HH_TRANSACTION = transaction.transaction_id;
                }
                else
                {
                    MessageBox.Show("Транзакцію не було завершено!");
                    transaction.Dispose();
                    return;
                }
                transaction.Dispose();
            }

            ctx.ORDER_HEADERS.Add(header);
            ctx.SaveChanges();

            ctx.HISTORY_HEADERS.Add(history_header);
            ctx.SaveChanges();

            var lines = (from line in ctx.ORDER_LINES
                         where orderLines.Contains(line.OL_ID)
                         select line).ToList();

            foreach (var line in lines)
            {
                line.OL_ORDER_HEADER = header.OH_ID;

                var x = new HISTORY_LINES
                {
                    HL_ITEM = line.OL_ITEM,
                    HL_ORDER_HEADER = history_header.HH_ID,
                    HL_QUANTITY = line.OL_QUANTITY
                };
                ctx.HISTORY_LINES.Add(x);
                ctx.SaveChanges();
            }

            finished = true;
            
            MessageBox.Show("Дякуємо за покупку! \nОчікуйте СМС-повідомлення.");

            //https://control.txtlocal.co.uk/settings/apikeys/
            //login : a...g...e@gmail.com, password : Alexey99
            //settings -> API -> Create New API

            string apiKey = "yjNT3kjpc8o-ApVf7I4ZU4dVvA4ILFkqOb67eJvr9s	";
            string number = "+38"+customer.C_PHONE;
            string message = "Hello, it's Dominos! Your order #" + header.OH_ID + " will be delievered in an hour.";
                //"Замовлення №" + header.OH_ID + " буде доставлено протягом години. ";

            sendSMS sms = new sendSMS();
            string result = sms.sendMessage(apiKey, number, message);
            MessageBox.Show(result);

            this.Close();
        }

        private void textBoxApp_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) &&
                e.KeyCode != Keys.Tab && e.KeyCode != Keys.Back)
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
