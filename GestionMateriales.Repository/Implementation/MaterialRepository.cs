using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GestionMateriales.Repository.Implementation
{
    public class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        public MaterialRepository(DbContext Context) : base(Context)
        {
        }

        public override Material FindOne(Expression<Func<Material, bool>> predicate = null)
        {
            return context.Set<Material>().Where(predicate)
               .Include(x => x.TipoMaterialIdTipoMaterialNavigation)
               .Include(x => x.ProveedorIdProveedorNavigation)
               .Include(x => x.UnidadIdUnidadNavigation)
               .Include(x => x.Entradamaterial)
               .Include(x => x.Salidamaterial)
               .ToList()
               .FirstOrDefault();
        }

        public override Material FindById(int id)
        {
            return context.Set<Material>().Where(x => x.IdMaterial == id)
                .Include(x => x.TipoMaterialIdTipoMaterialNavigation)
                .Include(x => x.ProveedorIdProveedorNavigation)
                .Include(x => x.UnidadIdUnidadNavigation)
                .ToList()
                .FirstOrDefault();
        }

        public override IEnumerable<Material> Find(Expression<Func<Material, bool>> predicate = null)
        {
            return context.Set<Material>().Where(predicate)
                .Include(x => x.TipoMaterialIdTipoMaterialNavigation)
                .Include(x => x.ProveedorIdProveedorNavigation)
                .Include(x => x.UnidadIdUnidadNavigation)
                .ToList();
        }
    }
}