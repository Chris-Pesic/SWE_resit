using StarterApp.ViewModels;

namespace StarterApp.Views;

public partial class ConferencePage : ContentPage
{
    public ConferencePage(ConferenceViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}