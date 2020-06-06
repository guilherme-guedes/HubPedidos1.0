using HubPedidos.v1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HubPedidos.v1.Data.Maps
{
    public class ProductMappings : EntityMappings<Product>
    {
        public override void ConfigureCustomFields(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");  
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Price).IsRequired();
        }
    }
}