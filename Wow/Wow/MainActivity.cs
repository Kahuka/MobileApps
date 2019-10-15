using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace Wow
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        Button _button1;
        Button _button2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _button1 = FindViewById<Button>(Resource.Id.nupp1);
            _button1.Click += Button_Click1;


            _button2 = FindViewById<Button>(Resource.Id.nupp2);
            _button2.Click += Button_Click2;



        }

        private void Button_Click1(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SecondActivity));
            this.StartActivity(intent);
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(ThirdActivity));
            this.StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}