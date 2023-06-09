using ProjetoYoutube.Data;
using ProjetoYoutube.Data.Base;
using ProjetoYoutube.Models;

namespace ProjetoYoutube.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
