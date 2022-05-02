using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.ViewModels;
using FinalProject.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProject
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(GameData data)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(data);
            if (FinalProject.GlobalVariables.counter >= 15)
            {
                upgrade.IsVisible = true;
            }
        }

        private void UpgradeButton_Clicked(object sender, EventArgs e)
        {
            FinalProject.GlobalVariables.upgradeButtonx2 = true;
            purchase.IsVisible = true;

            //couldn't figure out how to separate this button from the other buttons to get them to do the different powerups
        }

    }
}