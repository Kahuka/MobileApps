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

namespace StarWarsApp.StarWars
{
    [Activity(Label = "FilmsDetailsActivity")]
    public class FilmsDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.film_row_layout);

            var FilmTitle = FindViewById<TextView>(Resource.Id.textViewMovieTitle);
            var movieYearTextView = FindViewById<TextView>(Resource.Id.textViewReleaseDate);
            var movieDirectorTextView = FindViewById<TextView>(Resource.Id.textViewDirector);
            var movieProducerTextView = FindViewById<TextView>(Resource.Id.textViewProducer);
            var movieDescTextView = FindViewById<TextView>(Resource.Id.textViewDescription);

            var filmDetails = JsonConvert.DeserializeObject<Core.Models.FilmDetails>(Intent.GetStringExtra("movieDetails"));
            movieYearTextView.Text = filmDetails.Release_date.Year.ToString();
            movieDirectorTextView.Text = "Directed by: " + filmDetails.Director;
            movieProducerTextView.Text = "Produced by: " + filmDetails.Producer;
            movieDescTextView.Text = filmDetails.Opening_crawl;


        }
    }
}