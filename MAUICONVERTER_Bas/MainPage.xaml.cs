using MAUICONVERTER_Bas.Pages;
using Microsoft.VisualBasic;

namespace MAUICONVERTER_Bas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void information_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bytes());
        }

        private async void volume_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Volume());
        }

        private async void length_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Length());
        }

        private async void mass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mass());
        }

        private async void temperature_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Temperature());
        }

        private  async void energy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Energy());
        }

        private async void area_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Area());
        }

        private async void speed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Speed());
        }

        private async void duration_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Duration());
        }
    }

}
