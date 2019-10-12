using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;
using System.Linq;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Implementation
{
    public class PersonalRepository : Repository<Personal>, IPersonalRepository
    {
        public PersonalRepository(DbContext Context) : base(Context)
        {
        }

        public IEnumerable<Personal> GetAll()
        {
            return context.Set<Personal>().Where(x => x.Hab);
        }

        public Personal GetLastUpdated()
        {
            return context.Set<Personal>().Where(x => x.Hab).OrderByDescending(x => x.LastUpdatedDate).ToList().FirstOrDefault();
        }
    }
}