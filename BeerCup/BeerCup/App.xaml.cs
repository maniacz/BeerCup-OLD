using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BeerCup.Services;
using BeerCup.Views;

namespace BeerCup
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
            //MainPage = new TestPage();
            //MainPage = new VotingPage();
            //MainPage = new CreateAccountPage();
            MainPage = new BeerCodingPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
