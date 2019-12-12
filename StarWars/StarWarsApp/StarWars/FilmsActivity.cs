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
using StarWarsApp.Core;
using static Android.Widget.AdapterView;

namespace StarWarsApp.StarWars
{
    [Activity(Label = "FilmsActivity")]
    public class FilmsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Film_Layout);
            // Create your application here

            var StarWarsbtn1 = FindViewById<Button>(Resource.Id.btnStarWars1);
            var StarWarsbtn2 = FindViewById<Button>(Resource.Id.btnStarWars2);
            var StarWarsbtn3 = FindViewById<Button>(Resource.Id.btnStarWars3);
            var StarWarsbtn4 = FindViewById<Button>(Resource.Id.btnStarWars4);
            var StarWarsbtn5 = FindViewById<Button>(Resource.Id.btnStarWars5);
            var StarWarsbtn6 = FindViewById<Button>(Resource.Id.btnStarWars6);
            var StarWarsbtn7 = FindViewById<Button>(Resource.Id.btnStarWars7);

            StarWarsbtn1.Click += async delegate
            {
                string searchWord = "1";
                string queryString = "https://swapi.co/api/starships/" + searchWord;
                var data = await DataService.GetStarWarsStarships(queryString);
                // peopleListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);
                var intent = new Intent(this, typeof(FilmsDetailsActivity));

                this.StartActivity(intent);

            };
            StarWarsbtn2.Click += async delegate
            {
                string searchWord = "2";
                string queryString = "https://swapi.co/api/starships/" + searchWord;
                var data = await DataService.GetStarWarsStarships(queryString);
                // peopleListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);
                var intent = new Intent(this, typeof(FilmsDetailsActivity));

                this.StartActivity(intent);

            };
            StarWarsbtn3.Click += async delegate
            {
                string searchWord = "3";
                string queryString = "https://swapi.co/api/starships/" + searchWord;
                var data = await DataService.GetStarWarsStarships(queryString);
                // peopleListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);
                var intent = new Intent(this, typeof(FilmsDetailsActivity));

                this.StartActivity(intent);

            };
            StarWarsbtn4.Click += async delegate
            {
                string searchWord = "4";
                string queryString = "https://swapi.co/api/starships/" + searchWord;
                var data = await DataService.GetStarWarsStarships(queryString);
                // peopleListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);
                var intent = new Intent(this, typeof(FilmsDetailsActivity));

                this.StartActivity(intent);

            };
            StarWarsbtn5.Click += async delegate
            {
                string searchWord = "5";
                string queryString = "https://swapi.co/api/starships/" + searchWord;
                var data = await DataService.GetStarWarsStarships(queryString);
                // peopleListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);
                var intent = new Intent(this, typeof(FilmsDetailsActivity));

                this.StartActivity(intent);
            };
            StarWarsbtn6.Click += async delegate
            {
                string searchWord = "6";
                string queryString = "https://swapi.co/api/starships/" + searchWord;
                var data = await DataService.GetStarWarsStarships(queryString);
                // peopleListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);
                var intent = new Intent(this, typeof(FilmsDetailsActivity));

                this.StartActivity(intent);
            };
            StarWarsbtn7.Click += async delegate
            {
                string searchWord = "7";
                string queryString = "https://swapi.co/api/starships/" + searchWord;
                var data = await DataService.GetStarWarsStarships(queryString);
                // peopleListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);
                var intent = new Intent(this, typeof(FilmsDetailsActivity));

                this.StartActivity(intent);
            };


        }
    }
}