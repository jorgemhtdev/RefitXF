namespace RefitXF.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IApiService
    {
        Task<IEnumerable<Models.Film>> GetAllFilm();

        Task<Models.Film> GetFilmById(int id);
    }
}
