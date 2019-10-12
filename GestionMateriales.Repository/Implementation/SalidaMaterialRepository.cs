using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GestionMateriales.Repository.Implementation
{
    public class SalidaMaterialRepository : Repository<Salidamaterial>, ISalidaMaterialRepository
    {
        public SalidaMaterialRepository(DbContext Context) : base(Context)
        {
        }

        public override IEnumerable<Salidamaterial> Find(Expression<Func<Salidamaterial, bool>> predicate = null)
        {
            return context.Set<Salidamaterial>().Where(predicate)
               .Include(x => x.TipoSalidaMaterialIdTipoSalidaMaterialNavigation)
               .Include(x => x.MaterialIdMaterialNavigation)
               .ToList();
        }
    }
}