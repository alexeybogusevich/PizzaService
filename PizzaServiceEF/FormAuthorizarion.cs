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
    public partial class FormAuthorizarion : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;
        public int user_id;
        public bool authorized = false;
        public bool registerMode = false;

        public FormAuthorizarion()
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
            labelRegister.AutoSize = false;
            labelRegister.Paint += labelRegister_Paint;
        }

        private void labelRegister_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(buttonRegister.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(labelRegister.Text, labelRegister.Font);
            labelRegister.Width = (int)textSize.Height + 2;
            labelRegister.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-labelRegister.Height / 2, labelRegister.Width / 2);
            e.Graphics.DrawString(labelRegister.Text, labelRegister.Font, Brushes.White, -(textSize.Width / 2), -(textSize.Height / 2));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            var query = (from u in ctx.USERS
                         where u.U_LOGIN.Equals(login)
                         select u);

            if (query.Count() == 0)
            {
                MessageBox.Show("Користувача не знайдено!");
                return;
            }

            if(query.First().U_PASSWORD.Equals(password))
            {
                MessageBox.Show("Успіх!");
                user_id = query.First().U_ID;
                authorized = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Невірний пароль!");
            }

        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;

            var query = (from u in ctx.USERS
                         where u.U_LOGIN.Equals(login)
                         select u);

            if (query.Count() == 0)
            {
                pictureBoxNotOK.Visible = true;
                pictureBoxOK.Visible = false;
            }
            else
            {
                pictureBoxOK.Visible = true;
                pictureBoxNotOK.Visible = false;
                labelModifier.Text = query.First().U_MODIFIER;
                labelModifier.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegister registration = new FormRegister();
            registration.ShowDialog(this);
            registration.Dispose();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void labelRegister_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void labelRegister_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
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
    }
}
