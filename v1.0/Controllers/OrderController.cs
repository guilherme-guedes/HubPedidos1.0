using System.Collections.Generic;
using System.Threading.Tasks;
using HubPedidos.v1.Data.Repositories;
using HubPedidos.v1.Data.Transaction;
using HubPedidos.v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HubPedidos.v1.Controllers
{
    [ApiController]
    [Route("v1/products")]
    public class OrderController : ControllerBase 
    {
        [HttpPost]
        [Route("")]
        public Order AddOrder(
            [FromServices] IUnitOfWork unit, 
            [FromServices] BaseRepository<Order> repository, 
            [FromBody] Order order)
        {
            repository.Add(order);   
            unit.Commit();  
            return order;            
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Order>>> GetOrders(
            [FromServices] BaseRepository<Order> repository)
        {
            return await repository.GetAsync(); 
        }
    }
} 