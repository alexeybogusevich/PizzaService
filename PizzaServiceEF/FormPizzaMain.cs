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
    public partial class FormPizzaService : Form
    {
        private bool authorized = false;
        private bool admin = false;
        private int user_id;
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

        private void CustomizePage()
        {
            var query = (from u in ctx.USERS
                         where u.U_ID == user_id
                         select u).First();

            var customer = (from c in ctx.CUSTOMERS
                            where c.C_USERID == user_id
                            select c).First();

            MessageBox.Show("Вітаємо, " + customer.C_NAME + "!");

            if(query.U_MODIFIER == "A")
            {
                admin = true;
                AdminMode();
            }
            else
            {
                UserMode();
            }
        }

        private void UserMode()
        {
            throw new NotImplementedException();
        }

        private void AdminMode()
        {
            buttonComment.Visible = false;
            buttonOrder.Visible = false;
            buttonRestaurants.Visible = false;
            buttonAdmin.Visible = true;
            throw new NotImplementedException();
        }
    }
}
