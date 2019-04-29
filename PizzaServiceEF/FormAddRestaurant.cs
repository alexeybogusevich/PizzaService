using Geocoding;
using Geocoding.Google;
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
    public partial class FormAddRestaurant : Form
    {
        private PizzaServiceDataEF.PizzaServiceEntities ctx;

        public FormAddRestaurant()
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

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxAddress.Text == null || textBoxAddress.Text == "" ||
                textBoxCity.Text == null || textBoxAddress.Text == "")
            {
                MessageBox.Show("Заповнення усіх полів обов'язкове!", "Увага");
                return;
            }

            var store = new STORES
            {
                S_CITY = textBoxCity.Text,
                S_ADDRESS = textBoxAddress.Text
            };

            string address = store.S_CITY + ", " + store.S_ADDRESS;
            (store.S_LATITUDE, store.S_LONGITUDE) = await LocationFromAddress(address);

            ctx.STORES.Add(store);
            ctx.SaveChanges();

            this.Close();
        }

        private async Task<(double, double)> LocationFromAddress(string address)
        {
            IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "123abc" }; //replace this with your apiKey
            IEnumerable<Address> addresses = await geocoder.GeocodeAsync(address);
            //MessageBox.Show("Formatted: " + addresses.First().FormattedAddress); //Formatted: 1600 Pennsylvania Ave SE, Washington, DC 20003, USA
            //MessageBox.Show("Coordinates: " + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude); //Coordinates: 38.8791981, -76.9818437
            return (addresses.First().Coordinates.Latitude, addresses.First().Coordinates.Longitude);
        }
    }
}
