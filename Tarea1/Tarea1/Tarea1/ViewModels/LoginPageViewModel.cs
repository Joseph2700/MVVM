using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Tarea1.Models;
using Xamarin.Forms;

namespace Tarea1.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public LoginUser LoginUser { get; set; } = new LoginUser();
        public ICommand LoginCommand { get; set; }
        public ICommand GoToSignUp { get; set; }
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () =>
            {
                if(string.IsNullOrEmpty(LoginUser.UserName) || (string.IsNullOrEmpty(LoginUser.Password)))
                {
                    await App.Current.MainPage.DisplayAlert("Campos Vacios", "Favor llenar todos los campos", "OK");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new DiscoveryPage());
                }
            });

            GoToSignUp = new Command(async () =>
           {
               await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
           });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
