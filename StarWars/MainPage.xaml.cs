using StarWars.Service;

namespace StarWars
{
    public partial class MainPage : ContentPage
    {
        private readonly IStarWarsService _starWarsService;

        public MainPage(IStarWarsService service)
        {
            InitializeComponent();
            _starWarsService = service;
        }

        private async void OnDataClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            //var data = await _starWarsService.GetPersonajesAsync();
            var data = await _starWarsService.GetPlanetsAsync();

            listViewPlanets.ItemsSource = data;

            loading.IsVisible = false;
        }
    }
}
