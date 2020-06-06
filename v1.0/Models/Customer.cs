using System;

namespace HubPedidos.v1.Models
{
    public class Customer : Entity
    {
        public String Name { get; private set;}
        public DateTime Birth {get;set;}        
        public virtual Order Order {get;set;}

        public Customer(String name)
        {
            this.Name = name;
        }
    }
}