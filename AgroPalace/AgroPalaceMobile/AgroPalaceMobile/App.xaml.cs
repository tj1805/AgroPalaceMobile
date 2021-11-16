using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgroPalaceMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

              //  MainPage = new NavigationPage(new CreateAccount());
            //  MainPage = new HomePage();
           MainPage = new TabPage();
            //MainPage =  new CreateAccount();
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
