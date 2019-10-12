using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class ItemOrdenTrabajoAplicacionRepository : Repository<Itemordentrabajoaplicacion>, IItemOrdenTrabajoAplicacionRepository
    {
        public ItemOrdenTrabajoAplicacionRepository(DbContext Context) : base(Context)
        {
        }
    }
}