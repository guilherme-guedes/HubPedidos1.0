using HubPedidos.v1.Models;
using Microsoft.EntityFrameworkCore;

namespace HubPedidos.v1.Data
{
    public abstract class AbstractDataContext : DbContext
    {
        protected AbstractDataContext(DbContextOptions<DataContext> options) :  base(options){}
      
        #region DbSets

        internal DbSet<Customer> Customers {get;set;}        
        internal DbSet<Order> Orders {get;set;}        
        internal DbSet<OrderItem> OrderItems {get;set;}
        internal DbSet<Product> Products {get;set;}

        #endregion
    }
}