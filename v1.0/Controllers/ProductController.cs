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
    [Route("v1/products")]
    public class ProductController : ControllerBase 
    {        
        [HttpPost]
        [Route("")]
        public Product AddProduct(
            [FromServices] IUnitOfWork unit, 
            [FromServices] BaseRepository<Product> repository, 
            [FromBody] Product product)
        {
            repository.Add(product);   
            unit.Commit();  
            return product;            
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> GetProduct([FromServices] DataContext context)
        {
            using(var uow = new UnitOfWork(context))
            {
               var repo = new ProductRepository(uow);
               return await repo.GetAsync();     
            }
        }
    }
} 