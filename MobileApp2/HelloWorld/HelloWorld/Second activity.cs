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

namespace HelloWorld
{
    [Activity(Label = "Second_activity")]
    public class Second_activity : Activity
    {
        TextView _redtxt;
        TextView _orangetxt;
        TextView _yellowtxt;
        TextView _greentxt;
        TextView _bluetxt;
        TextView _indigotxt;
        TextView _violettxt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.secondlayout);
            // Create your application here

            //_redtxt = FindViewById<TextView>(Resource.Id.redtxt);
            //_orangetxt = FindViewById<TextView>(Resource.Id.orangetxt);
            //_yellowtxt = FindViewById<TextView>(Resource.Id.yellowtxt);
            //_greentxt = FindViewById<TextView>(Resource.Id.greentxt);
            //_bluetxt = FindViewById<TextView>(Resource.Id.bluetxt);
            //_indigotxt = FindViewById<TextView>(Resource.Id.indigotxt);
            //_violettxt = FindViewById<TextView>(Resource.Id.violettxt);


        }


    }
}