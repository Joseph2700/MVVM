using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Tarea1.Models;
using Xamarin.Forms;

namespace Tarea1.ViewModels
{
    public class DiscoveryViewModel : INotifyPropertyChanged
    {
        public DiscoveryModel BarsHotels { get; set; } = new DiscoveryModel();
        public DiscoveryModel FineDinning { get; set; } = new DiscoveryModel();
        public DiscoveryModel Cafes { get; set; } = new DiscoveryModel();
        public DiscoveryModel Nearby { get; set; } = new DiscoveryModel();
        public DiscoveryModel FastFoods { get; set; } = new DiscoveryModel();
        public DiscoveryModel FeaturedFoods { get; set; } = new DiscoveryModel();

        public DiscoveryViewModel()
        {
            BarsHotels.Title = "Bars and Hotels";
            BarsHotels.Description = "42 Place";
            BarsHotels.Image = "ic_beer.jpeg";

            FineDinning.Title = "Fine Dinning";
            FineDinning.Description = "15 Place";
            FineDinning.Image = "ic_plate.png";

            Cafes.Title = "Cafes";
            Cafes.Description = "28 Place";
            Cafes.Image = "ic_cafe.png";

            Nearby.Title = "Nearby";
            Nearby.Description = "34 Place";
            Nearby.Image = "ic_gps.png";

            FastFoods.Title = "Fast Foods";
            FastFoods.Description = "29 Place";
            FastFoods.Image = "ic_pizza.png";

            FeaturedFoods.Title = "Featured Foods";
            FeaturedFoods.Description = "21 Place";
            FeaturedFoods.Image = "ic_soda.png";
        }

        public event PropertyChangedEventHandler PropertyChanged;        
    }
}
