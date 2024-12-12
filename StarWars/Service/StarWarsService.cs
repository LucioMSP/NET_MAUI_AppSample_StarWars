using StarWars.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace StarWars.Service
{
    public class StarWarsService : IStarWarsService
    {
        // Variable privada
        private string urlAPI = "https://swapi.dev/api/";

        // Interface
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
    }
}
