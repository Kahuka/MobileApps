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
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var _items = new List<CarInfo>()
            {
                new CarInfo(){Car = "Audi", Manufacturer = "12c", Model = "4m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Teisipäev", Manufacturer = "10c", Model = "2m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Kolmapäev", Manufacturer = "9c", Model = "7m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Neljapäev", Manufacturer = "15c", Model = "5m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Reede", Manufacturer = "13c", Model = "2m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Laupäev", Manufacturer = "11c", Model = "1m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Pühapäev", Manufacturer = "12c", Model = "4m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Reede", Manufacturer = "13c", Model = "2m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Laupäev", Manufacturer = "11c", Model = "1m/s", Year = "", KW = ""},
                new CarInfo(){Car = "Pühapäev", Manufacturer = "12c", Model = "4m/s", Year = "", KW = ""},
            };

            // Create your application here
            SetContentView(Resource.Layout.SecondLayout);

            var listView = FindViewById<ListView>(Resource.Id.listView1);



            listView.Adapter = new BasicAdapter(this, _items);
        }
    }
}
