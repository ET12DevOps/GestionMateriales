using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class TipoEntradaMaterialRepository : Repository<Tipoentradamaterial>, ITipoEntradaMaterialRepository
    {
        public TipoEntradaMaterialRepository(DbContext Context) : base(Context)
        {
        }
    }
}