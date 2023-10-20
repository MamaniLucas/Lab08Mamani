using Lab08Mamani.Services;
using Lab08Mamani.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab08Mamani
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
