using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoMovil
{
    public partial class App : Application
    {

        public static FlyoutPage flyoutPage {get;set;} 
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MaestroDetalle());
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
 