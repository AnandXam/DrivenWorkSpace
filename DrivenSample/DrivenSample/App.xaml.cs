using DrivenSample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrivenSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Dashbord());
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#0D1017");

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
