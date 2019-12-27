namespace RefitXF.Services
{
    using Refit;
    using RefitXF.Services.Film;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ApiService : IApiService
    {
        private string baseUrl = "https://my-json-server.typicode.com/jorgemht/demo/";

        private readonly IFilmService filmService;

        public ApiService()
        {
            filmService = RestService.For<IFilmService>(baseUrl);
        }

        public async Task<IEnumerable<Models.Film>> GetAllFilm() => await filmService.GetAll();

        public async Task<Models.Film> GetFilmById(int id)
        {
            IEnumerable<Models.Film> films = await filmService.GetById(id);

            return films.ToList().FirstOrDefault();
        }
    }
}
