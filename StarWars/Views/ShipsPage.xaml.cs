using StarWars.Service;

namespace StarWars.Views;

public partial class ShipsPage : ContentPage
{
    private readonly IStarWarsService _starWarsService;
    public ShipsPage(IStarWarsService service)
	{
		InitializeComponent();
        _starWarsService = service;
    }

    private async void OnDataClicked(object sender, EventArgs e)
    {
        loading.IsVisible = true;

        var data = await _starWarsService.GetStarShipsAsync();
        listViewStarShips.ItemsSource = data;

        loading.IsVisible = false;
    }
}