using System.Collections.Generic;
using System.Threading.Tasks;
using HubPedidos.v1.Data;
using HubPedidos.v1.Data.Repository;
using HubPedidos.v1.Data.Transaction;
using HubPedidos.v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HubPedidos.v1.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase 
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Customer>>> GetCustomers([FromServices] DataContext context)
        {
            using(var uow = new UnitOfWork(context))
            {
               var repo = new CustomerRepository(uow);
               return await repo.GetAsync();     
            }
        }
    }
} 