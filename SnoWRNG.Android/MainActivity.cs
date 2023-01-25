using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace SnoWRNG.Android;

[Activity(Label = "SnoWRNG.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
public class MainActivity : AvaloniaMainActivity
{
}
