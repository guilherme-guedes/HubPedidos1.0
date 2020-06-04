using System.Collections.Generic;
using System.Threading.Tasks;
using HubPedidos.v1.Data;
using HubPedidos.v1.Data.Repositories;
using HubPedidos.v1.Data.Transaction;
using HubPedidos.v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HubPedidos.v1.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase 
    {        
        [HttpPost]
        [Route("")]
        public Customer AddCustomer(
            [FromServices] IUnitOfWork unit, 
            [FromServices] BaseRepository<Customer> repository, 
            [FromBody] Customer customer)
        {
            repository.Add(customer);   
            unit.Commit();  
            return customer;            
        }

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