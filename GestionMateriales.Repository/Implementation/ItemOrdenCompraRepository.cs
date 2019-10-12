using Microsoft.EntityFrameworkCore;
using GestionMateriales.Repository.Models;
using GestionMateriales.Repository.Contracts;

namespace GestionMateriales.Repository.Implementation
{
    public class ItemOrdenCompraRepository : Repository<Itemordencompra>, IItemOrdenCompraRepository
    {
        public ItemOrdenCompraRepository(DbContext Context) : base(Context)
        {
        }
    }
}