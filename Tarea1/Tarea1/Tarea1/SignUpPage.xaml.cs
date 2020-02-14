using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async void buttonSignUpPage_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entrySignUpEmail.Text) || string.IsNullOrEmpty(entrySignUpUsername.Text) || string.IsNullOrEmpty(entrySignUpPassword.Text) || string.IsNullOrEmpty(entrySignUpRPassword.Text))
            {
                await DisplayAlert("Campos Vacios", "Favor llenar todos los campos", "OK");
            }
            await Navigation.PushAsync(new DiscoveryPage());
        }
    }
}