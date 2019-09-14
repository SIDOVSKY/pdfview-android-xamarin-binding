using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace PDFViewAndroid.Sample
{
    [Activity(
        Label = "@string/app_name",
        Theme = "@style/AppTheme.NoActionBar",
        MainLauncher = true)]
    public class MainActivity : AppCompatActivity
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