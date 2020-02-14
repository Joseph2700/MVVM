using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void buttonLoginPage_Clicked(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(entryLoginUsername.Text) || string.IsNullOrEmpty(entryLoginPassword.Text))
            {
                await DisplayAlert("Campos Vacios", "Favor llenar todos los campos", "OK");
            }
            await Navigation.PushAsync(new DiscoveryPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
