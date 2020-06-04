using HubPedidos.v1.Data.Transaction;
using HubPedidos.v1.Models;

namespace HubPedidos.v1.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}