using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProject
{
    public partial class GamePage : ContentPage
    {
        //int counter = 0;
        public GamePage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(12), () =>
            {
                if (FinalProject.GlobalVariables.upgradeButtonx2)
                {
                    FinalProject.GlobalVariables.counter += 10;
                    plus5.Text = "+10";
                }
                /*
                else if (FinalProject.GlobalVariables.upgradeButtonx3)
                {
                    FinalProject.GlobalVariables.counter += 15;
                    plus5.Text = "+15";
                }
                else if (FinalProject.GlobalVariables.upgradeButtonx4)
                {
                    FinalProject.GlobalVariables.counter += 20;
                    plus5.Text = "+20";
                }
                */
                else //no powerups
                {
                    FinalProject.GlobalVariables.counter += 5;
                    plus5.Text = "+5";
                }

                plus5.IsVisible = true;

                return true;
            });
        }

        private void AboutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void InstructionButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructionsPage());
        }

        private void ShopButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShopPage());
        }

        private void IceCreamButton_Clicked(object sender, EventArgs e)
        {
            if (FinalProject.GlobalVariables.upgradeButtonx2) {
                FinalProject.GlobalVariables.counter += 2;
            }
            /*
            else if (FinalProject.GlobalVariables.upgradeButtonx3)
            {
                FinalProject.GlobalVariables.counter += 3;
            }
            else if (FinalProject.GlobalVariables.upgradeButtonx4)
            {
                FinalProject.GlobalVariables.counter += 4;
            }
            */
            else //no powerups
            {
                FinalProject.GlobalVariables.counter++;
            }

            plus5.IsVisible = false;
            clickCounts.Text = "Ice Cream: " + FinalProject.GlobalVariables.counter;
        }
    }
}
