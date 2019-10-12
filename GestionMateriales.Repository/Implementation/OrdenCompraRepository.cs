using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GestionMateriales.Repository.Implementation
{
    public class OrdenCompraRepository : Repository<Ordencompra>, IOrdenCompraRepository
    {
        public OrdenCompraRepository(DbContext Context) : base(Context)
        {
        }

        public override Ordencompra FindById(int id)
        {
            return context.Set<Ordencompra>().Where(x => x.IdOrdenCompra == id)
                .Include(x => x.ProveedorIdProveedorNavigation)
                .Include(x => x.ResponsableIdPersonalNavigation)
                .Include(x => x.Itemordencompra)
                .FirstOrDefault();
        }

        public override Ordencompra FindOne(Expression<Func<Ordencompra, bool>> predicate)
        {
            return context.Set<Ordencompra>().Where(predicate)
                .Include(x => x.ProveedorIdProveedorNavigation)
                .Include(x => x.ResponsableIdPersonalNavigation)
                .Include(x => x.Itemordencompra)
                .ToList()
                .FirstOrDefault();
        }
    }
}