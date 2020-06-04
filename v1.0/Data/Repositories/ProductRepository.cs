using HubPedidos.v1.Data.Transaction;
using HubPedidos.v1.Models;

namespace HubPedidos.v1.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}