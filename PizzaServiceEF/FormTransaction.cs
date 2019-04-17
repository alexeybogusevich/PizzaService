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
    public partial class FormTransaction : Form
    {
        private bool starting = true;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        public int transaction_id;
        public bool finished = false;

        public FormTransaction(double sum)
        {
            InitializeComponent();
            ctx = new PizzaServiceEntities();

            labelSum.Text = sum.ToString() + " грн.";
            SetTabIndexes(this);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(!checkBoxApprove.Checked)
            {
                MessageBox.Show("Необхідна згода з вимогами публічної пропозиції!", "Увага!");
                return;
            }

            if (textBoxCard1.Text == "" || textBoxCard2.Text == "" ||
                textBoxCard3.Text == "" || textBoxCard4.Text == "" ||
                textBoxCVV.Text == "" || comboBoxYear.Text == "" ||
                comboBoxMonth.Text == "" || textBoxCard2.Text == null ||
                textBoxCard3.Text == null || textBoxCard4.Text == null ||
                textBoxCVV.Text == null || textBoxCard1.Text == null ||
                comboBoxMonth.Text == null || comboBoxYear.Text == null)
            {
                MessageBox.Show("Заповнення усіх полів необхідне!", "Помилка");
                return;
            }

            if(textBoxCard1.Text.Length != 4 || textBoxCard2.Text.Length != 4 ||
                textBoxCard3.Text.Length != 4 || textBoxCard4.Text.Length != 4)
            {
                MessageBox.Show("Вказаний номер картки не є коректним", "Помилка");
                return;
            }

            if(textBoxCVV.Text.Length != 3)
            {
                MessageBox.Show("Некоректний формат CVV");
                return;
            }

            DateTime date = new DateTime(Convert.ToInt32("20" + comboBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text), 1);

            var transaction = new TRANSACTIONS
            {
                T_DATE = System.DateTime.Now,
                T_EXPIRE_DATE = date,
                T_RRN = textBoxCard1.Text + textBoxCard2.Text + textBoxCard3.Text + textBoxCard4.Text
            };

            ctx.TRANSACTIONS.Add(transaction);
            ctx.SaveChanges();

            transaction_id = transaction.T_ID;
            finished = true;

            MessageBox.Show("Транзакцію успішно виконано!");

            this.Close();
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

        private void textBoxCard_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                && e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Tab)
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxCard1.Text = "";
            }
        }

        private void textBoxCVV_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                && e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Tab)
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxCVV.Text = "";
                return;
            }
        }

        private void textBoxCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBoxCard1.Text.Length == 4 && e.KeyChar != (int)Keys.Back)
            {
                e.KeyChar = '\0';
            }
        }

        private void textBoxCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBoxCVV.Text.Length == 3 && e.KeyChar != (int)Keys.Back)
            {
                e.KeyChar = '\0';
            }
        }

        private void FormTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!finished)
            {
                string message = "Транзакцію не завершено! Закрити вікно?";
                string caption = "Увага";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    // Closes the parent form.
                    e.Cancel = true;
                }
            }
        }

        private void textBoxCard2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
              && (e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Tab))
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxCard2.Text = "";
            }
        }

        private void textBoxCard3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
              && (e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Tab &&
              e.KeyCode != Keys.Left && e.KeyCode != Keys.Right))
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxCard3.Text = "";
            }
        }

        private void textBoxCard4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Tab &&
              e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxCard4.Text = "";
            }
        }

        private void textBoxCard2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxCard2.Text.Length == 4 && e.KeyChar != (int)Keys.Back)
            {
                e.KeyChar = '\0';
            }
        }

        private void textBoxCard3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxCard3.Text.Length == 4 && e.KeyChar != (int)Keys.Back)
            {
                e.KeyChar = '\0';
            }
        }

        private void textBoxCard4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxCard4.Text.Length == 4 && e.KeyChar != (int)Keys.Back)
            {
                e.KeyChar = '\0';
            }
        }
    }
}
