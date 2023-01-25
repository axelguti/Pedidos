using PedFast.Services;
using PedFast.Shells;
using PedFast.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedFast
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            
        }

        protected override void OnStart()
        {
            MainPage = new LoginShell();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
