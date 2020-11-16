﻿using Android.App;
using Android.OS;

namespace PDFViewAndroid.Sample
{
    [Activity(
        Label = "@string/app_name",
        Theme = "@style/AppTheme",
        MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            FindViewById<PDFView>(Resource.Id.activityMainPdfView)
                .FromAsset("great-expectations.pdf")
                .Show();
        }
    }
}