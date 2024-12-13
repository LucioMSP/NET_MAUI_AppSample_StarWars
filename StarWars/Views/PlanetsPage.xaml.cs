using StarWars.Service;

namespace StarWars.Views;

public partial class PlanetsPage : ContentPage
{
    private readonly IStarWarsService _starWarsService;
    public PlanetsPage(IStarWarsService service)
	{
		InitializeComponent();
        _starWarsService = service;
    }

    private async void OnDataClicked(object sender, EventArgs e)
    {
        loading.IsVisible = true;

        var data = await _starWarsService.GetPlanetsAsync();
        listViewPlanets.ItemsSource = data;

        loading.IsVisible = false;
    }
}