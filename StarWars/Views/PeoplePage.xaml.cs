using StarWars.Service;

namespace StarWars.Views;

public partial class PeoplePage : ContentPage
{
    private readonly IStarWarsService _starWarsService;
    public PeoplePage(IStarWarsService service)
	{
		InitializeComponent();
        _starWarsService = service;
    }

    private async void OnDataClicked(object sender, EventArgs e)
    {
        loading.IsVisible = true;

        var data = await _starWarsService.GetPersonajesAsync();
        listViewPeople.ItemsSource = data;

        loading.IsVisible = false;
    }
}