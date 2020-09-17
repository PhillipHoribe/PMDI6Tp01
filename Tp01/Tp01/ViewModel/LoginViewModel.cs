using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tp01.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.Notify("id");
            }
        }
        string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                this.Notify("password");
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand LimparCommand { get; set; }

        /*public ICommand LimparCommand {
            get
            {
                return new Command(async () =>
                {
                    this.Id = string.Empty;
                    this.Password = string.Empty;
                });
            }
        }*/

        public ICommand CreditosCommand { get; set; }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _NavigationService;
        public LoginViewModel()
        {
            this.LoginCommand = new Command(this.Login);
            this.LimparCommand = new Command(this.Limpar);
            this.CreditosCommand = new Command(this.Creditos);
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._NavigationService = DependencyService.Get<Services.INavigationService>();
        }

        private void Login() {
            if (this.Id == "admin" && this.Password == "@dmin"){
                this._NavigationService.NavigateToMain();
            }
            else{
                this._messageService.ShowAsync("Login Negado");
            }
        }
        private void Limpar() {
         
        }
        private void Creditos() {
            this._NavigationService.NavigateToCreditos();
        }
    }
}
