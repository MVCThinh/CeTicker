using _1.eTickers.Data.Base;
using _1.eTickers.Models;

namespace _1.eTickers.Data.Services
{
    public class ActorsService : EntityBaseRespository<Actor> , IActorsService
    {
        public ActorsService(AppDbContext context) : base(context)
        {

        }
    }
}
