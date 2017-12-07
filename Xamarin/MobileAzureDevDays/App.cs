using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MobileAzureDevDays.Pages;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobileAzureDevDays
{
    public class App : Application
    {
        public App() => MainPage = new HomePage();
    }
}
