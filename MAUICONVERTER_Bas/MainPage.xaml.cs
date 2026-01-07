using MAUICONVERTER_Bas.Pages;
using MAUICONVERTER_Bas.ViewModel;
using Microsoft.VisualBasic;
using System;

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
            var button = (ImageButton)sender;

            string option = char.ToUpper(button.StyleId[0]) + button.StyleId.Substring(1);


            var converterView = new ConVerty
            {
                BindingContext = new ConverterViewModel(option)
            };

            Navigation.PushAsync(converterView);
        }

        
    }

}
