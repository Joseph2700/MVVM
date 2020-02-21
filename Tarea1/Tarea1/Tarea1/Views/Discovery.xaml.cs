using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Models;
using Tarea1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Discovery : ContentPage
    {
        public Discovery()
        {
            InitializeComponent();
            BindingContext = new DiscoveryViewModel();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }       
    }
}