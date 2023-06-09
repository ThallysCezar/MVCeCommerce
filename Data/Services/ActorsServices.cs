using Microsoft.EntityFrameworkCore;
using ProjetoYoutube.Data.Base;
using ProjetoYoutube.Data.Services.Interfaces;
using ProjetoYoutube.Models;

namespace ProjetoYoutube.Data.Services
{
    public class ActorsServices : EntityBaseRepository<Actor>, IActorsServices
    {
        private readonly AppDbContext _context;

        public ActorsServices(AppDbContext context) : base(context) { }
    }
}
