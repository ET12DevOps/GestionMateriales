using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class TipoSalidaMaterialRepository : Repository<Tiposalidamaterial>, ITipoSalidaMaterialRepository
    {
        public TipoSalidaMaterialRepository(DbContext Context) : base(Context)
        {
        }
    }
}