using StarWars.Models;

namespace StarWars.Service
{
    public interface IStarWarsService
    {
        public Task<List<PersonajesResponse>> GetPersonajesAsync();
        public Task<List<PlanetsResponse>> GetPlanetsAsync();
        public Task<List<StarShipsResponse>> GetStarShipsAsync();

    }
}