using System;
using System.Collections.Generic;
using System.Text;

namespace Tp01.View.Services
{
    public class NavigatiionService : ViewModel.Services.INavigationService
    {
        //navegar para paginas
        public async System.Threading.Tasks.Task NavigateToCreditos()
        {
            await Tp01.App.Current.MainPage.Navigation.PushAsync(new View.CreditosView());
        }

        public async System.Threading.Tasks.Task NavigateToMain()
        {
            await Tp01.App.Current.MainPage.Navigation.PushAsync(new View.MainView());
        }
        public NavigatiionService()
        {

        }
    }
}
