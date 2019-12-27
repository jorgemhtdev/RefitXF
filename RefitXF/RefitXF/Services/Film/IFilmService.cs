namespace RefitXF.Services.Film
{
    using Refit;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IFilmService
    {
        [Get("/film")]
        Task<IEnumerable<Models.Film>> GetAll();

        [Get("/film?filmId={id}")]
        Task<IEnumerable<Models.Film>> GetById([AliasAs("id")] int filmId);

        [Post("/film")]
        Task AddFilm([Body] Models.Film film, [Header("Authorization")] string token);
    }
}
