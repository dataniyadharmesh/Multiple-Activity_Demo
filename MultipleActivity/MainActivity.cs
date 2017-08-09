using Android.App;
using Android.Widget;
using Android.OS;

namespace MultipleActivity
{
    [Activity(Label = "MultipleActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button btn_next, btn_last;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            btn_next = FindViewById<Button>(Resource.Id.buttonNext1);
            btn_last = FindViewById<Button>(Resource.Id.buttonLast1);

            btn_next.Click += delegate
            {
                //logonButtonClick();
                StartActivity(typeof(LayoutActivity1));
                Toast.MakeText(this, "Jump To Next Page ", ToastLength.Short).Show();

            };

            btn_last.Click += delegate
            {
                //logonButtonClick();
               
                Toast.MakeText(this, "No Have A Previous Page Pleasr Hit Next Button ", ToastLength.Short).Show();

            };




            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

