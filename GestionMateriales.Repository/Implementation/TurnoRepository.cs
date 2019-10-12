using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class TurnoRepository : Repository<Turno>, ITurnoRepository
    {
        public TurnoRepository(DbContext Context) : base(Context)
        {
        }
    }
}