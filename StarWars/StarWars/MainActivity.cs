using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace StarWars
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var searchField = FindViewById<EditText>(Resource.Id.);
            var searchButton = FindViewById<Button>(Resource.Id.);
            var peopleListView = FindViewById<ListView>(Resource.Id.);

            searchButton.Click += async delegate
            {

            }
        }
    }
}