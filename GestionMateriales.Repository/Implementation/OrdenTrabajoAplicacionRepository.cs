using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GestionMateriales.Repository.Implementation
{
    public class OrdenTrabajoAplicacionRepository : Repository<Ordentrabajoaplicacion>, IOrdenTrabajoAplicacionRepository
    {
        public OrdenTrabajoAplicacionRepository(DbContext Context) : base(Context)
        {
        }

        public override Ordentrabajoaplicacion FindById(int id)
        {
            return context.Set<Ordentrabajoaplicacion>().Where(x => x.IdOrdenTrabajoAplicacion == id)
                .Include(x => x.IdTurnoNavigation)
                .Include(x => x.ResponsableIdPersonalNavigation)
                .Include(x => x.JefeSeccionIdPersonalNavigation)
                .ToList()
                .FirstOrDefault();
        }

        public override Ordentrabajoaplicacion FindOne(Expression<Func<Ordentrabajoaplicacion, bool>> predicate)
        {
            return context.Set<Ordentrabajoaplicacion>().Where(predicate)
                .Include(x => x.IdTurnoNavigation)
                .Include(x => x.ResponsableIdPersonalNavigation)
                .Include(x => x.JefeSeccionIdPersonalNavigation)
                .Include(x => x.Itemordentrabajoaplicacion)
                .ToList()
                .FirstOrDefault();
        }
    }
}