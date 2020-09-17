using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tp01.View.Services
{
    public class MessageService : ViewModel.Services.IMessageService
    {
        public async System.Threading.Tasks.Task ShowAsync(string message)
        {
            await Tp01.App.Current.MainPage.DisplayAlert("login", message ,"ok");
        }
    }
}
