using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class EntradaMaterialRepository : Repository<Entradamaterial>, IEntradaMaterialRepository
    {
        public EntradaMaterialRepository(DbContext Context) : base(Context)
        {
        }
    }
}