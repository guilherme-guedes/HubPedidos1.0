using HubPedidos.v1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HubPedidos.v1.Data.Maps
{
    public class CustomerMappings : EntityMappings<Customer>
    {
        public override void ConfigureCustomFields(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Consumers");   
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
        }
    }
}