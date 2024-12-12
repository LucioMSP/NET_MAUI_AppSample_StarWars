using StarWars.Models;

namespace StarWars.Service
{
    public interface IStarWarsService
    {
        //Método (Tarea Asincrona)
        public Task<List<PersonajesResponse>> GetPersonajesAsync();
        public Task<List<PlanetsResponse>> GetPlanetsAsync();
    }
}