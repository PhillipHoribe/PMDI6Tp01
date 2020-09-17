using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ViewModel.Services.IMessageService, View.Services.MessageService>();
            DependencyService.Register<ViewModel.Services.INavigationService, View.Services.NavigatiionService>();
            MainPage = new NavigationPage(new View.LoginView());
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
