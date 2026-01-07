using MAUICONVERTER_Bas.ViewModel;

namespace MAUICONVERTER_Bas.Pages;

public partial class ConVerty : ContentPage
{
	public ConVerty()
	{
		InitializeComponent();


     
}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var viewModel = (ConverterViewModel)BindingContext;
        viewModel.Convert();
    }
}