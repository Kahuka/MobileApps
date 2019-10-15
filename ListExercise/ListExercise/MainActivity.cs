using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System;

namespace ListExercise
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var toCarInfo2Button = FindViewById<Button>(Resource.Id.carinfo2);
            var toCarInfoButton = FindViewById<Button>(Resource.Id.carinfo);

            toCarInfoButton.Click += ToCarInfoButton_Click;
            toCarInfo2Button.Click += ToCarInfo2Button_Click;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void ToCarInfoButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CarActivity));
            StartActivity(intent);
        }

        private void ToCarInfo2Button_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(FirstExampleActivity));
            StartActivity(intent);
        }
    }
}