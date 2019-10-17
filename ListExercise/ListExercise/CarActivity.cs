using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListExercise
{
    [Activity(Label = "CarActivity")]
    public class CarActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CarLayout);
            var _items = new List<CarInfo>()
            {
                new CarInfo(){Manufacturer = "Audi", Model = "Paudi", Year = "1980", KW = "123"},
                new CarInfo(){Manufacturer = "Honda", Model = "Wonda", Year = "2200", KW = "133"},
                new CarInfo(){Manufacturer = "Fiat", Model = "Kiat", Year = "4212", KW = "163"},
                new CarInfo(){Manufacturer = "BMW", Model = "SMW", Year = "1245", KW = "143"},
                new CarInfo(){Manufacturer = "Alfa Romeo", Model = "Delta Belta", Year = "1990", KW = "222"},
                new CarInfo(){Manufacturer = "Volkswagen", Model = "Mastermagen", Year = "1980", KW = "14"},
                new CarInfo(){Manufacturer = "Chevrolet", Model = "Korolet", Year = "1895", KW = "754"},
                new CarInfo(){Manufacturer = "Ford", Model = "Bored", Year = "1995", KW = "432"},
                new CarInfo(){Manufacturer = "Hyundai", Model = "Sundai", Year = "2012", KW = "123"},
                new CarInfo(){Manufacturer = "Jeep", Model = "Peep", Year = "2002", KW = "64"},
            };

            // Create your application here


            var listView = FindViewById<ListView>(Resource.Id.listView1);
            listView.Adapter = new BasicAdapter(this, _items);
        }
    }
}