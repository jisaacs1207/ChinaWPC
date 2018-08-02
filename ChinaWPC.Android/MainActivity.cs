using Android.App;
using Android.Content.PM;
using Android.OS;

namespace ChinaWPC.Droid
{
    [Activity(Label = "ChinaWPC", 
              Icon = "@mipmap/icon", 
              Theme = "@style/MainTheme", 
              MainLauncher = true, 
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
              ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            FormsPlugin.Iconize.Droid.IconControls.Init(Resource.Id.toolbar);
            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());
            base.OnCreate(bundle);
           

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

        }
        
        
    }
}

