using _1.eTickers.Data.Base;
using _1.eTickers.Models;

namespace _1.eTickers.Data.Services
{
    public class CinemasService : EntityBaseRespository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
