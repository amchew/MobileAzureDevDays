using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MobileAzureDevDays.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            Xamarin.Calabash.Start();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
            AppCenter.Start("09d24657-d101-405a-8f75-7aa95be4b54c", typeof(Analytics), typeof(Crashes));
        }
    }
}
