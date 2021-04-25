using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_practice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            switch (Device.Idiom) {

                case TargetIdiom.Phone: 
                    MainPage = new MainPage(); 
                    break;

                case TargetIdiom.Desktop: 
                    MainPage = new Page_Desktop();
                    break;
            }
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
