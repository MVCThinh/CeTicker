using _1.eTickers.Data.Base;
using _1.eTickers.Data.ViewModels;
using _1.eTickers.Models;

namespace _1.eTickers.Data.Services
{
    public interface IMoviesService : IEntityBaseRespository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
