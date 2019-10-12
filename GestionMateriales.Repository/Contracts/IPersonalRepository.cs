using GestionMateriales.Repository.Models;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Contracts
{
    public interface IPersonalRepository : IRepository<Personal>
    {
        IEnumerable<Personal> GetAll();

        Personal GetLastUpdated();
    }
}
