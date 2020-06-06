using System.Collections.Generic;

namespace HubPedidos.v1.Models
{
    public class Product : Entity
    {
        public string  Name { get;set;}
        public long Price {get;set;}
        public virtual List<OrderItem> OrderItems {get;set;}
    }
}