using ProjetoYoutube.Data.Base;
using ProjetoYoutube.Models;

namespace ProjetoYoutube.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
