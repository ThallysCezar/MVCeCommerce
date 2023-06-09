using ProjetoYoutube.Data.Base;
using ProjetoYoutube.Data.ViewModels;
using ProjetoYoutube.Models;

namespace ProjetoYoutube.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
