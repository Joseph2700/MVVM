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

        private void TappedBarsHotels(object sender, EventArgs e)
        {
            BarsHotels.BackgroundColor = Color.Gold;
            Cafes.BackgroundColor = default;
            FastFoods.BackgroundColor = default;
            FineDinning.BackgroundColor = default;
            Nearby.BackgroundColor = default;
            FeaturedFoods.BackgroundColor = default;
        }

        private void TappedCafes(object sender, EventArgs e)
        {
            BarsHotels.BackgroundColor = default;
            Cafes.BackgroundColor = Color.Gold;
            FastFoods.BackgroundColor = default;
            FineDinning.BackgroundColor = default;
            Nearby.BackgroundColor = default;
            FeaturedFoods.BackgroundColor = default;
        }

        private void TappedFastFoods(object sender, EventArgs e)
        {
            BarsHotels.BackgroundColor = default;
            Cafes.BackgroundColor = default;
            FastFoods.BackgroundColor = Color.Gold;
            FineDinning.BackgroundColor = default;
            Nearby.BackgroundColor = default;
            FeaturedFoods.BackgroundColor = default;
        }

        private void TappedFineDinning(object sender, EventArgs e)
        {
            BarsHotels.BackgroundColor = default;
            Cafes.BackgroundColor = default;
            FastFoods.BackgroundColor = default;
            FineDinning.BackgroundColor = Color.Gold;
            Nearby.BackgroundColor = default;
            FeaturedFoods.BackgroundColor = default;
        }

        private void TappedNearby(object sender, EventArgs e)
        {
            BarsHotels.BackgroundColor = default;
            Cafes.BackgroundColor = default;
            FastFoods.BackgroundColor = default;
            FineDinning.BackgroundColor = default;
            Nearby.BackgroundColor = Color.Gold;
            FeaturedFoods.BackgroundColor = default;
        }

        private void TappedFeaturedFoods(object sender, EventArgs e)
        {
            BarsHotels.BackgroundColor = default;
            Cafes.BackgroundColor = default;
            FastFoods.BackgroundColor = default;
            FineDinning.BackgroundColor = default;
            Nearby.BackgroundColor = default;
            FeaturedFoods.BackgroundColor = Color.Gold;
        }
    }
}