using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class TipoMaterialRepository : Repository<Tipomaterial>, ITipoMaterialRepository
    {
        public TipoMaterialRepository(DbContext Context) : base(Context)
        {
        }
    }
}