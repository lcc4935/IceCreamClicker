using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public static class GlobalVariables
    {
        public static int counter = 0;
        public static bool upgradeButtonx2 = false;
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Start_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePage());
        }

    }
}
