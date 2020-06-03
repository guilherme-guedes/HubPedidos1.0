using HubPedidos.v1.Data.Transaction;
using HubPedidos.v1.Models;

namespace HubPedidos.v1.Data.Repository
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}