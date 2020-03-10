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
using Newtonsoft.Json;
using StarWarsApp.Core;
using static Android.Widget.AdapterView;

namespace StarWarsApp.StarWars
{
    [Activity(Label = "FilmsActivity")]
    public class FilmsActivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Film_layout);
            // Create your application here

            var filmListView = FindViewById<ListView>(Resource.Id.Films_List);

            string queryString = "https://swapi.co/api/films/";
            var data = await DataService.GetStarWarsFilms(queryString);
            filmListView.Adapter = new StarWarsFilmsAdapter(this, data.Results);

            filmListView.ItemClick += (object sender, ItemClickEventArgs e) =>
            {
                //var clickPostitionText = moviesListView.GetItemAtPosition(e.Position); // Show text
                //var clickPostitionID = Convert.ToString(e.Position); // Show index
                var movieDetails = data.Results[e.Position];

                var intent = new Intent(this, typeof(FilmsDetailsActivity));
                intent.PutExtra("movieDetails", JsonConvert.SerializeObject(movieDetails));
                StartActivity(intent);
            };
        }
    }
}