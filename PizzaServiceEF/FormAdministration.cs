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
    public partial class FormAdministration : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public FormAdministration()
        {
            InitializeComponent();
            ctx = new PizzaServiceDataEF.PizzaServiceEntities();

            var orderHeaders = (from header in ctx.ORDER_HEADERS
                         select header).OrderByDescending(x=>x.OH_DATE);

            var historyHeaders = (from h in ctx.HISTORY_HEADERS
                                  select h).OrderByDescending(x => x.HH_DATE);

            var items = (from i in ctx.ITEMS
                         orderby i.I_CATEGORY, i.I_NAME
                         select i);

            var customers = (from c in ctx.CUSTOMERS
                             select c);

            var users = (from u in ctx.USERS
                         select u);

            var stores = (from s in ctx.STORES
                          select s);

            sTORESBindingSource.DataSource = stores.ToList();
            uSERSBindingSource.DataSource = users.ToList();
            iTEMSBindingSource.DataSource = items.ToList();
            hISTORYHEADERSBindingSource.DataSource = historyHeaders.ToList();
            cUSTOMERSBindingSource.DataSource = customers.ToList();
            oRDERHEADERSBindingSource.DataSource = orderHeaders.ToList();
        }

        private void buttonOrderDone_Click(object sender, EventArgs e)
        {
            int header = (int)dataGridViewOrderHeaders.CurrentRow.Cells["oHIDDataGridViewTextBoxColumn"].Value;

            var lines = (from line in ctx.ORDER_LINES
                         where line.OL_ORDER_HEADER == header
                         select line).ToList();

            foreach(var line in lines)
            {
                ctx.ORDER_LINES.Remove(line);
                ctx.SaveChanges();
            }

            oRDERHEADERSBindingSource.RemoveCurrent();
        }

        private void dataGridViewOrderHeaders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dataGridViewOrderHeaders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int header = (int)dataGridViewOrderHeaders.CurrentRow.Cells["oHIDDataGridViewTextBoxColumn"].Value;
            FormHistoryLinesAdmin historyLinesAdmin = new FormHistoryLinesAdmin(header);
            historyLinesAdmin.ShowDialog(this);
            historyLinesAdmin.Dispose();
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime x = DateTime.Now;

            if(comboBoxTime.SelectedIndex == 0)
            {
                x = DateTime.MinValue;
            }
            else if(comboBoxTime.SelectedIndex == 1)
            {
                x = new DateTime(x.Year - 1, x.Month, x.Day);
            }
            else if(comboBoxTime.SelectedIndex == 2)
            {
                x = new DateTime(x.Year, x.Month - 1, x.Day);
            }
            else
            {
                x = new DateTime(x.Year, x.Month, x.Day - 1);
            }

            var query = (from h in ctx.HISTORY_HEADERS
                         where h.HH_DATE > x
                         select h);

            hISTORYHEADERSBindingSource.DataSource = query.ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string message = "Ви впевнені, що хочете видалити цю страву?";
            string caption = "Увага";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            int item_id = (int)dataGridViewItems.CurrentRow.Cells["iIDDataGridViewTextBoxColumn"].Value;

            var countLines = (from h in ctx.HISTORY_LINES
                              where h.HL_ITEM == item_id
                              select h).Count();

            var countNewLines = (from o in ctx.ORDER_LINES
                                 where o.OL_ITEM == item_id
                                 select o).Count();

            if(countLines != 0 || countNewLines != 0)
            {
                MessageBox.Show("У базі присутні замовлення, які включають в себе дану страву!\n" +
                    "Видалення неможливе", "Увага");
                return;
            }
            else
            {
                if (dataGridViewItems.CurrentRow.Cells["iCATEGORYDataGridViewTextBoxColumn"].Value.ToString().Equals("Піца"))
                {
                    string pName = dataGridViewItems.CurrentRow.Cells["iNAMEDataGridViewTextBoxColumn"].Value.ToString();
                    var lines = (from i in ctx.ITEMS
                                 where i.I_NAME.Equals(pName)
                                 select i).ToList();

                    foreach (var line in lines)
                    {
                        ctx.ITEMS.Remove(line);
                        ctx.SaveChanges();
                    }
                }
                else
                {
                    var item = (from i in ctx.ITEMS
                                where i.I_ID == item_id
                                select i).First();

                    ctx.ITEMS.Remove(item);
                    ctx.SaveChanges();
                }
            }

            var items = (from i in ctx.ITEMS
                         orderby i.I_CATEGORY, i.I_NAME
                         select i);

            iTEMSBindingSource.DataSource = items.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddItem addItem = new FormAddItem();
            addItem.ShowDialog(this);
            addItem.Dispose();

            var items = (from i in ctx.ITEMS
                         orderby i.I_CATEGORY, i.I_NAME
                         select i);

            iTEMSBindingSource.DataSource = items.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Ви впевнені, що хочете видалити цього користувача?";
            string caption = "Увага";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            string modifier = dataGridViewUsers.CurrentRow.Cells["uMODIFIERDataGridViewTextBoxColumn"].Value.ToString();
            if(modifier.Equals("A"))
            {
                MessageBox.Show("Видалення адміністратора неможливе", "Помилка");
                return;
            }

            int user_id = (int)dataGridViewUsers.CurrentRow.Cells["uIDDataGridViewTextBoxColumn"].Value;

            var user = (from x in ctx.USERS
                         where x.U_ID == user_id
                         select x).First();

            ctx.USERS.Remove(user);
            ctx.SaveChanges();

            var users = (from u in ctx.USERS
                         select u);

            uSERSBindingSource.DataSource = users.ToList();
        }

        private void buttonSaveStore_Click(object sender, EventArgs e)
        {
            FormAddRestaurant addRestaurant = new FormAddRestaurant();
            addRestaurant.ShowDialog(this);
            addRestaurant.Dispose();

            var stores = (from s in ctx.STORES
                          select s);

            sTORESBindingSource.DataSource = stores.ToList();
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = (int)dataGridViewItems.CurrentRow.Cells["iIDDataGridViewTextBoxColumn"].Value;
            if (dataGridViewItems.CurrentCell.ColumnIndex == 5)
            {
                FormItemImage itemImage = new FormItemImage(item);
                itemImage.ShowDialog(this);
                itemImage.Dispose();
            }
        }

        private void buttonDeleteStore_Click(object sender, EventArgs e)
        {
            string message = "Ви впевнені, що хочете видалити цей ресторан?";
            string caption = "Увага";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            int store_id = (int)dataGridViewRestaurants.CurrentRow.Cells["sIDDataGridViewTextBoxColumn"].Value;

            var storeOrderCount = (from line in ctx.ORDER_HEADERS
                         where line.OH_STORE == store_id
                         select line).Count();

            if(storeOrderCount != 0)
            {
                MessageBox.Show("В цьому ресторані є незавершені замовлення!\nВидалення неможливе.", "Увага");
                return;
            }

            var store = (from s in ctx.STORES
                         where s.S_ID == store_id
                         select s).First();

            ctx.STORES.Remove(store);
            ctx.SaveChanges();

            var stores = (from s in ctx.STORES
                          select s);

            sTORESBindingSource.DataSource = stores.ToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearchItems searchItems = new FormSearchItems();
            searchItems.ShowDialog(this);

            string category = searchItems.category;
            string ingredient = searchItems.ingerdients;
            int price = searchItems.price;

            if(category != null && ingredient != null && price != 0)
            {
                var query = (from i in ctx.ITEMS
                              where i.I_DESCRIPTION.Contains(ingredient) && i.I_PRICE < price && i.I_CATEGORY.Equals(category)
                              select i);

                iTEMSBindingSource.DataSource = query.ToList();
                return;
            }
            else
            {
                if(category != null && price != 0)
                {
                    var query = (from i in ctx.ITEMS
                                 where i.I_PRICE < price && i.I_CATEGORY.Equals(category)
                                 select i);

                    iTEMSBindingSource.DataSource = query.ToList();
                    return;
                }

                else if(category != null && ingredient != null)
                {
                    var query = (from i in ctx.ITEMS
                                 where i.I_DESCRIPTION.Contains(ingredient) && i.I_CATEGORY.Equals(category)
                                 select i);

                    iTEMSBindingSource.DataSource = query.ToList();
                    return;
                }
                else if(price != 0 && ingredient != null)
                {
                    var query = (from i in ctx.ITEMS
                                 where i.I_DESCRIPTION.Contains(ingredient) && i.I_PRICE < price
                                 select i);

                    iTEMSBindingSource.DataSource = query.ToList();
                    return;
                }
                else if(category != null)
                {
                    var query = (from i in ctx.ITEMS
                                 where i.I_CATEGORY.Equals(category)
                                 select i);

                    iTEMSBindingSource.DataSource = query.ToList();
                    return;
                }
                else if(price != 0)
                {
                    var query = (from i in ctx.ITEMS
                                 where i.I_PRICE < price
                                 select i);

                    iTEMSBindingSource.DataSource = query.ToList();
                    return;
                }
                else
                {
                    var query = (from i in ctx.ITEMS
                                 where i.I_DESCRIPTION.Contains(ingredient)
                                 select i);

                    iTEMSBindingSource.DataSource = query.ToList();
                    return;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var query = (from i in ctx.ITEMS
                         select i);

            iTEMSBindingSource.DataSource = query.ToList();
            return;
        }

        private void dataGridViewItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
