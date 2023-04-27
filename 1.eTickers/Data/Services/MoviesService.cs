using _1.eTickers.Data.Base;
using _1.eTickers.Models;

namespace _1.eTickers.Data.Services
{
    public class MoviesService : EntityBaseRespository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context)
        {
        }
    }
}
