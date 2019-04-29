using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleMaps.LocationServices;
using PizzaServiceDataEF;
using Geocoding;
using Geocoding.Google;
using GMap.NET.WindowsForms;
using System.IO;

namespace PizzaServiceEF
{
    public partial class FormMaps : Form
    {
        PizzaServiceDataEF.PizzaServiceEntities ctx;
        private int store_id;
        private string address;

        public FormMaps()
        {
            InitializeComponent();
            ctx = new PizzaServiceEntities(); 
            SetMap();
        }

        public FormMaps(int storeID, string address_)
        {
            InitializeComponent();
            store_id = storeID;
            ctx = new PizzaServiceEntities();
            address = address_;

            SetMapRoute();
        }

        private async void SetMapRoute()
        {
            Map.DragButton = MouseButtons.Left;
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.ShowCenter = false;

            Map.Position = new GMap.NET.PointLatLng(50.44, 30.52);
            Map.MinZoom = 5;
            Map.MaxZoom = 100;
            Map.Zoom = 10;

            (double customersLatitude, double customersLongitude) = await LocationFromAddress(address);

            GMap.NET.PointLatLng customersPoint = new GMap.NET.PointLatLng();
            customersPoint.Lat = customersLatitude;
            customersPoint.Lng = customersLongitude;

            var store = (from s in ctx.STORES
                         where s.S_ID == store_id
                         select s).First();

            string storeAddress = store.S_CITY.Trim() + ", " + store.S_ADDRESS;

            GMap.NET.PointLatLng storesPonit = new GMap.NET.PointLatLng();
            customersPoint.Lat = (double)store.S_LATITUDE;
            customersPoint.Lng = (double)store.S_LONGITUDE;

            var route = GoogleMapProvider.Instance.GetRoute(storesPonit, customersPoint, false, false, 14);

            var r = new GMapRoute(route.Points, "Delievery")
            {
                Stroke = new Pen(Color.Red, 5)
            };

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            Map.Overlays.Add(routes);

            System.Threading.Thread.Sleep(15000);
            this.Close();
        }

        private void SetMap()
        {
            Map.DragButton = MouseButtons.Left;
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.ShowCenter = false;

            Map.Position = new GMap.NET.PointLatLng(50.44, 30.52);
            Map.MinZoom = 5;
            Map.MaxZoom = 100;
            Map.Zoom = 10;

            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            //GMap.NET.WindowsForms.Markers.GMarkerGoogle testMarker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
            //    new GMap.NET.PointLatLng(50.44, 30.52), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red);
            //markers.Markers.Add(testMarker);
            Map.Overlays.Add(markers);

            var restaurants = (from s in ctx.STORES
                               select s);

            foreach (var store in restaurants)
            {
                string address = store.S_CITY.Trim() + ", " + store.S_ADDRESS;
                GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng((double)store.S_LATITUDE, (double)store.S_LONGITUDE), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red);
                markers.Markers.Add(marker);
                Map.Overlays.Add(markers);
            }
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
