﻿using System;
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
                new CarInfo(){Car = "Audi", Manufacturer = "12c", Model = "4m/s", Year = "1980", KW = "123"},
                new CarInfo(){Car = "Teisipäev", Manufacturer = "10c", Model = "2m/s", Year = "2200", KW = "133"},
                new CarInfo(){Car = "Kolmapäev", Manufacturer = "9c", Model = "7m/s", Year = "4212", KW = "163"},
                new CarInfo(){Car = "Neljapäev", Manufacturer = "15c", Model = "5m/s", Year = "1245", KW = "143"},
                new CarInfo(){Car = "Reede", Manufacturer = "13c", Model = "2m/s", Year = "1990", KW = "222"},
                new CarInfo(){Car = "Laupäev", Manufacturer = "11c", Model = "1m/s", Year = "1980", KW = "14"},
                new CarInfo(){Car = "Pühapäev", Manufacturer = "12c", Model = "4m/s", Year = "1895", KW = "754"},
                new CarInfo(){Car = "Reede", Manufacturer = "13c", Model = "2m/s", Year = "1995", KW = "432"},
                new CarInfo(){Car = "Laupäev", Manufacturer = "11c", Model = "1m/s", Year = "2012", KW = "123"},
                new CarInfo(){Car = "Pühapäev", Manufacturer = "12c", Model = "4m/s", Year = "2002", KW = "64"},
            };

            // Create your application here


            var listView = FindViewById<ListView>(Resource.Id.listView1);
            listView.Adapter = new BasicAdapter(this, _items);
        }
    }
}