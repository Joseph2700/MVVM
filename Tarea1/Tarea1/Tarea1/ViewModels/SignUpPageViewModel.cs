using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Tarea1.Models;
using Xamarin.Forms;

namespace Tarea1.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public SignUpUser SignUpUser { get; set; } = new SignUpUser();
        public ICommand SignUpCommand { get; set; }
        public ICommand GoToLogin { get; set; }
        public SignUpPageViewModel()
        {
            SignUpCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(SignUpUser.EmailAddress) || string.IsNullOrEmpty(SignUpUser.UserName) || string.IsNullOrEmpty(SignUpUser.Password) || string.IsNullOrEmpty(SignUpUser.RepeatPassword))
                {
                    await App.Current.MainPage.DisplayAlert("Campos Vacios", "Favor llenar todos los campos", "OK");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new DiscoveryPage());
                }
            });

            GoToLogin = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
