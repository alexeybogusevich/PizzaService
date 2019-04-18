using PizzaServiceDataEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaServiceEF
{
    public partial class FormAddItem : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private string name;
        private string category;

        public FormAddItem()
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
            const int logo_id = 70;

            if (comboBoxCategory.Text == "" || comboBoxCategory.Text == null ||
                 textBoxName.Text == "" || textBoxName.Text == null ||
                 textBoxS.Text == null || textBoxS.Text == "" ||
                 (comboBoxCategory.SelectedIndex == 0 && (textBoxM.Text == null || textBoxM.Text == "" || 
                 textBoxL.Text == null || textBoxL.Text == "")))
            {
                MessageBox.Show("Усі поля є обов'язковими для заповнення!", "Увага");
                return;
            }

            category = comboBoxCategory.Text;
            name = textBoxName.Text;

            var item1 = new ITEMS
            {
                I_DESCRIPTION = richTextBoxDescription.Text,
                I_CATEGORY = comboBoxCategory.Text,
                I_PRICE = Decimal.Parse(textBoxS.Text, CultureInfo.InvariantCulture),
                I_NAME = textBoxName.Text,
                I_IMAGE = logo_id
            };

            if(comboBoxCategory.SelectedIndex == 0)
            {
                var item2 = new ITEMS
                {
                    I_DESCRIPTION = richTextBoxDescription.Text,
                    I_CATEGORY = comboBoxCategory.Text,
                    I_PRICE = Decimal.Parse(textBoxM.Text, CultureInfo.InvariantCulture),
                    I_NAME = textBoxName.Text,
                    I_SIZE = "M",
                    I_IMAGE = logo_id
                };

                var item3 = new ITEMS
                {
                    I_DESCRIPTION = richTextBoxDescription.Text,
                    I_CATEGORY = comboBoxCategory.Text,
                    I_PRICE = Decimal.Parse(textBoxL.Text, CultureInfo.InvariantCulture),
                    I_NAME = textBoxName.Text,
                    I_SIZE = "L",
                    I_IMAGE = logo_id
                };

                item1.I_SIZE = "S";

                ctx.ITEMS.Add(item2);
                ctx.ITEMS.Add(item3);
                ctx.SaveChanges();
            }

            ctx.ITEMS.Add(item1);

            try
            {
                ctx.SaveChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Помилка при додаванні нової страви!", "Увага");
                this.Close();
            }
            this.Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCategory.SelectedIndex != 0)
            {
                labelL.Visible = false;
                labelM.Visible = false;
                labelS.Visible = false;
                textBoxL.Visible = false;
                textBoxM.Visible = false;
            }
            else
            {
                labelL.Visible = true;
                labelM.Visible = true;
                labelS.Visible = true;
                textBoxL.Visible = true;
                textBoxM.Visible = true;
            }
            textBoxS.Text = "";
            textBoxM.Text = "";
            textBoxL.Text = "";
        }

        private void textBoxS_Leave(object sender, EventArgs e)
        {
            string s = textBoxS.Text;
            int indexOfDot = -1;
            if(s != null)
            {
                for(int i = 0; i < s.Length; ++i)
                {
                    if(!Char.IsDigit(s[i]) && s[i] != '.')
                    {
                        MessageBox.Show("Неприпустимий формат ціни!\nВикористовуйте арабські цифри та роздільник '.'",
                            "Увага");
                        textBoxS.Text = "";
                        return;
                    }

                    if(s[i] == '.')
                    {
                        indexOfDot = i;
                        if(i+3 < s.Length)
                        {
                            textBoxS.Text = s.Substring(0, i + 3);
                            return;
                        }
                    }
                }
            }
        }

        private void textBoxM_Leave(object sender, EventArgs e)
        {
            string s = textBoxM.Text;
            int indexOfDot = -1;
            if (s != null)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (!Char.IsDigit(s[i]) && s[i] != '.')
                    {
                        MessageBox.Show("Неприпустимий формат ціни!\nВикористовуйте арабські цифри та роздільник '.'",
                            "Увага");
                        textBoxM.Text = "";
                        return;
                    }

                    if (s[i] == '.')
                    {
                        indexOfDot = i;
                        if (i + 3 < s.Length)
                        {
                            textBoxM.Text = s.Substring(0, i + 3);
                            return;
                        }
                    }
                }
            }
        }

        private void textBoxL_Leave(object sender, EventArgs e)
        {
            string s = textBoxL.Text;
            int indexOfDot = -1;
            if (s != null)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (!Char.IsDigit(s[i]) && s[i] != '.')
                    {
                        MessageBox.Show("Неприпустимий формат ціни!\nВикористовуйте арабські цифри та роздільник '.'",
                            "Увага");
                        textBoxL.Text = "";
                        return;
                    }

                    if (s[i] == '.')
                    {
                        indexOfDot = i;
                        if (i + 3 < s.Length)
                        {
                            textBoxL.Text = s.Substring(0, i + 3);
                            return;
                        }
                    }
                }
            }
        }

        private void textBoxS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((textBoxS.Text.Length == 6 && !textBoxS.Text.Contains('.') && e.KeyChar != (int)Keys.Back
                && e.KeyChar != (int)Keys.OemPeriod) ||
                (textBoxS.Text.Length == 9 && textBoxS.Text.Contains('.') && e.KeyChar != (int)Keys.Back))
            {
                e.KeyChar = '\0';
            }
        }

        private void textBoxM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((textBoxM.Text.Length == 6 && !textBoxM.Text.Contains('.') && e.KeyChar != (int)Keys.Back
                && e.KeyChar != (int)Keys.OemPeriod) ||
                (textBoxM.Text.Length == 9 && textBoxM.Text.Contains('.') && e.KeyChar != (int)Keys.Back))
            {
                e.KeyChar = '\0';
            }
        }

        private void textBoxL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((textBoxL.Text.Length == 6 && !textBoxL.Text.Contains('.') && e.KeyChar != (int)Keys.Back 
                && e.KeyChar != (int)Keys.OemPeriod) ||
                (textBoxL.Text.Length == 9 && textBoxL.Text.Contains('.') && e.KeyChar != (int)Keys.Back))
            {
                e.KeyChar = '\0';
            }
        }
    }
}
