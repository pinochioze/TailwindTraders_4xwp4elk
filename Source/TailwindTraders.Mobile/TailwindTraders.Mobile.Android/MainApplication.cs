using System;
using Android.App;
using Android.Runtime;
using Plugin.CurrentActivity;
using TailwindTraders.Mobile.Features.Settings;

[assembly: Xamarin.Forms.ResolutionGroupName(nameof(TailwindTraders))]

namespace TailwindTraders.Mobile.Droid
{
    [Application(Debuggable = DefaultSettings.AndroidDebuggable)]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer)
            : base(handle, transer)
        {
            Crashes.GenerateTestCrash();
            try {
            // your code here.
            
            } catch (Exception exception) {
            var properties = new Dictionary<string, string> {
                { "Category", "Music" },
                { "Wifi", "On" }
            };
            Crashes.TrackError(exception, properties);
            }

        }

        public override void OnCreate()
        {
            base.OnCreate();

            CrossCurrentActivity.Current.Init(this);
        }
    }
}