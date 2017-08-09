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

namespace MultipleActivity
{
    [Activity(Label = "LayoutActivity4")]
    public class LayoutActivity4 : Activity
    {
        private Button btn_next, btn_last;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout4);

            // Create your application here
            btn_next = FindViewById<Button>(Resource.Id.buttonNext1);
            btn_last = FindViewById<Button>(Resource.Id.buttonLast1);

            btn_next.Click += delegate
            {
                //logonButtonClick();
                StartActivity(typeof(LayoutActivity5));
                Toast.MakeText(this, "Jump To Next Page ", ToastLength.Short).Show();

            };

            btn_last.Click += delegate
            {
                //logonButtonClick();
                StartActivity(typeof(LayoutActivity3));
                Toast.MakeText(this, "Jump To Previous Page ", ToastLength.Short).Show();

            };


        }
    }
}