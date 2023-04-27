using _1.eTickers.Data.Base;
using _1.eTickers.Models;

namespace _1.eTickers.Data.Services
{
    public class ProducersService : EntityBaseRespository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
