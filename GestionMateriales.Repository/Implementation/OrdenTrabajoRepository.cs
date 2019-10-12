using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class OrdenTrabajoRepository : Repository<Ordentrabajo>, IOrdenTrabajoRepository
    {
        public OrdenTrabajoRepository(DbContext Context) : base(Context)
        {
        }
    }
}