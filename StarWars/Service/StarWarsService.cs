using StarWars.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace StarWars.Service
{
    public class StarWarsService : IStarWarsService
    {
        private string urlAPI = "https://swapi.dev/api/";

        public async Task<List<PersonajesResponse>> GetPersonajesAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlAPI + "people/");
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var personajeData = JsonSerializer.Deserialize<List<PersonajesResponse>>(results.ToString());
            return personajeData;
        }

        public async Task<List<PlanetsResponse>> GetPlanetsAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlAPI + "planets/");
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var planetsData = JsonSerializer.Deserialize<List<PlanetsResponse>>(results.ToString());
            return planetsData;
        }

        public async Task<List<StarShipsResponse>> GetStarShipsAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlAPI + "starships/");
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var starshipsData = JsonSerializer.Deserialize<List<StarShipsResponse>>(results.ToString());
            return starshipsData;
        }
    }
}
