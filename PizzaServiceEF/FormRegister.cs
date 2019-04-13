using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaServiceDataEF;


namespace PizzaServiceEF
{
    public partial class FormRegister : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        private bool namePhoneEmailStage = true;
        private string phoneNumber;
        private string name;
        private string email;
        private string login;
        private string password;

        public FormRegister()
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            SetTabIndexes(this);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(namePhoneEmailStage)
            {
                if(comboBox000.Text != "" && textBoxNumber.Text.Length == 7 && IsValidEmail(textBoxEmail.Text))
                {
                    var phoneCount = (from c in ctx.CUSTOMERS
                                     where c.C_PHONE.Equals(comboBox000.Text + textBoxNumber.Text)
                                     select c).Count();

                    if(phoneCount != 0)
                    {
                        MessageBox.Show("Користувача з таким номером телефону вже зареєстровано!", "Помилка");
                        return;
                    }

                    var emailCount = (from c in ctx.CUSTOMERS
                                      where c.C_EMAIL.Equals(textBoxEmail.Text)
                                      select c).Count();

                    if(emailCount != 0)
                    {
                        MessageBox.Show("Користувача з таким адресом електронної пошти вже зареєстровано!", "Помилка");
                        return;
                    }

                    phoneNumber = comboBox000.Text + textBoxNumber.Text;
                    name = textBoxName.Text;
                    email = textBoxEmail.Text;
                    buttonNext.Text = "Зареєструватись";

                    labelPhone.Visible = false;
                    textBoxName.Visible = false;
                    textBoxNumber.Visible = false;
                    textBoxEmail.Visible = false;
                    labelPhone.Visible = false;
                    labelEmail.Visible = false;
                    labelName.Visible = false;
                    comboBox000.Visible = false;

                    namePhoneEmailStage = false;

                    textBoxLogin.Visible = true;
                    textBoxPassword.Visible = true;
                    labelPassword.Visible = true;
                    labelLogin.Visible = true;

                    textBoxPassword.PasswordChar = '•';

                    buttonNext.Location = new Point(this.buttonNext.Location.X, this.buttonNext.Location.Y - 20);
                    return;
                }
                else if (textBoxNumber.Text.Length != 7)
                {
                    MessageBox.Show("Некоректний номер телефону!", "Помилка");
                    textBoxNumber.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Заповнення всіх полів обов'язкове!");
                    return;
                }
            }
            else
            {
                if(textBoxLogin.Text == "" || textBoxLogin.Text == null 
                    || textBoxPassword.Text == "" || textBoxPassword.Text == null)
                {
                    MessageBox.Show("Заповнення усіх полів обов'язкове!", "Помилка!");
                    return;
                }
                
                if(textBoxPassword.Text.Length < 5)
                {
                    MessageBox.Show("Ненадійний пароль!", "Помилка");
                    return;
                }

                var existance = (from u in ctx.USERS
                             where u.U_LOGIN.Equals(textBoxLogin.Text)
                             select u).Count();

                if(existance != 0)
                {
                    MessageBox.Show("Користувача з таким логіном вже зареєстровано!");
                    textBoxPassword.Text = "";
                    return;
                }

                login = textBoxLogin.Text;
                password = textBoxPassword.Text;

                AddUser();
            }
        }

        private void AddUser()
        {
            var quantity = (from u in ctx.USERS
                            select u).Count();

            string modifier = "U";

            if(quantity == 0)
            {
                modifier = "A";
            }

            var user = new USERS
            {
                U_LOGIN = login,
                U_MODIFIER = modifier,
                U_PASSWORD = password
            };

            ctx.USERS.Add(user);
            ctx.SaveChanges();

            var customer = new CUSTOMERS
            {
                C_EMAIL = email,
                C_NAME = name,
                C_PHONE = phoneNumber,
                C_USERID = user.U_ID
            };

            ctx.CUSTOMERS.Add(customer);
            ctx.SaveChanges();

            MessageBox.Show(user.U_MODIFIER == "A" ? "Адміністраторa" : "Користувачa" + " успішно зареєстровано!");

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

        private void textBoxSecond_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                textBoxEmail.Focus();
            }
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) 
                && e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxNumber.Text = "";
            }
        }

        private void textBoxThird_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
                return;
            if(!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Некоректний Email!");
                textBoxEmail.Text = "";
            }
        }

        private void textBoxFourth_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                MessageBox.Show("Недопустимий символ!");
                textBoxPassword.Text = "";
                return;
            }
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
    }
}
