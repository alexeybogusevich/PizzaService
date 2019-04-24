using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaServiceEF
{
    public partial class FormPizzaService : Form
    {
        private bool authorized = false;
        private bool admin = false;
        private int user_id;
        private string user_name;
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public FormPizzaService()
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if(!authorized)
            {
                MessageBox.Show("Увійдіть в систему!");
                return;
            }
            FormPizzaOrder order = new FormPizzaOrder(user_id);
            this.Visible = false;
            order.ShowDialog(this);
            this.Visible = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(!CheckConnection())
            {
                MessageBox.Show("Ваш пристрій не підключено до мережі Інтернет! \nАвтономний режим недоступний.", "Увага");
                return;
            }

            FormAuthorizarion authorization = new FormAuthorizarion();
            authorization.ShowDialog(this);
            if (authorization.authorized)
            {
                user_id = authorization.user_id;
                this.authorized = true;
                CustomizePage();
            }
            authorization.Dispose();
        }

        private bool CheckConnection()
        {
            WebClient client = new WebClient();
            try
            {
                using (client.OpenRead("http://google.com"))
                {

                }
                return true;
            }
            catch(WebException)
            {
                return false;
            }
        }

        private void CustomizePage()
        {
            buttonEnter.Visible = false;
            buttonExit.Visible = true;

            var query = (from u in ctx.USERS
                         where u.U_ID == user_id
                         select u).First();

            if(query.U_MODIFIER == "A")
            {
                admin = true;
                AdminMode();
            }
            else
            {
                var customer = (from c in ctx.CUSTOMERS
                                where c.C_USERID == user_id
                                select c).First();

                user_name = customer.C_NAME;

                MessageBox.Show("Вітаємо, " + user_name.Trim() + "!");

                UserMode();
            }
        }

        private void UserMode()
        {
            menuStripMain.Visible = true;
            userNameToolStripMenuItem.Text = user_name;
        }

        private void AdminMode()
        {
            buttonComment.Visible = false;
            buttonOrder.Visible = false;
            buttonRestaurants.Visible = false;
            buttonAdmin.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string message = "Вийти з системи?";
            string caption = "Увага";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                // Closes the parent form.
                return;
            }
            else
            {
                DeCustomizePage();
            }
        }

        private void DeCustomizePage()
        {
            menuStripMain.Visible = false;
            buttonComment.Visible = true;
            buttonOrder.Visible = true;
            buttonRestaurants.Visible = true;
            buttonAdmin.Visible = false;
            buttonEnter.Visible = true;
            buttonExit.Visible = false;
            authorized = false;
        }

        private void активніЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActiveOrders activeOrders = new FormActiveOrders(user_id);
            activeOrders.ShowDialog(this);
            activeOrders.Dispose();
        }

        private void історіяЗамовленьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoryOrders historyOrders = new FormHistoryOrders(user_id);
            historyOrders.ShowDialog(this);
            historyOrders.Dispose();
        }

        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userNameToolStripMenuItem.ForeColor = Color.Black;
        }

        private void menuStripMain_MenuDeactivate(object sender, EventArgs e)
        {
            userNameToolStripMenuItem.ForeColor = Color.White;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            FormAdministration administration = new FormAdministration();
            administration.ShowDialog(this);
            administration.Dispose();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            if (!authorized)
            {
                MessageBox.Show("Увійдіть в систему!");
                return;
            }

            var customer_id = (from c in ctx.CUSTOMERS
                               where c.C_USERID == user_id
                               select c).First();

            FormReviews formReviews = new FormReviews(customer_id.C_ID);
            formReviews.ShowDialog(this);
            formReviews.Dispose();
        }

        private void buttonRestaurants_Click(object sender, EventArgs e)
        {
            if (!authorized)
            {
                MessageBox.Show("Увійдіть в систему!");
                return;
            }
            FormMaps formMaps = new FormMaps();
            formMaps.ShowDialog(this);
            formMaps.Dispose();
        }
    }
}
