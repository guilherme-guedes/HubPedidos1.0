
using System;

namespace HubPedidos.v1.Models
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }

        public string Id { get; private set; }
        public string ExternalCode { get; private set; }
        public DateTimeOffset CreatedAt { get; private set; }
        public DateTimeOffset LastUpdateAt { get; private set; }

        public void ModifiedEntity()
        {
            LastUpdateAt = DateTime.Now;
        }
    }
}