using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class UnidadRepository : Repository<Unidad>, IUnidadRepository
    {
        public UnidadRepository(DbContext Context) : base(Context)
        {
        }
    }
}