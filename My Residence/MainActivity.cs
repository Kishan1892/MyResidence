using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace My_Residence
{
    [Activity(Label = "My\nResidence", MainLauncher = true, Icon = "@drawable/ic_launcher")]
    public class MainActivity : Activity
    { 
        private Button enterResidence;
        private Button about;
    
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            GetViewComponents();
            HandleClicks();
        }

        private void GetViewComponents()
        {
            enterResidence = FindViewById<Button>(Resource.Id.btnMyResidence);
            about = FindViewById<Button>(Resource.Id.btnAbout);
        }

        private void HandleClicks()
        {
            enterResidence.Click += EnterResidence_Click;
            about.Click += About_Click;
        }

        private void About_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(AboutActivity));
            StartActivity(intent);
        }

        private void EnterResidence_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(EnterResidenceActivity));
            StartActivity(intent);
        }
    }
}

