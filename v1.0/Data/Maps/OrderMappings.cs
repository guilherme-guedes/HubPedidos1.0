using HubPedidos.v1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HubPedidos.v1.Data.Maps
{
    public class OrderMappings : EntityMappings<Order>
    {
        public override void ConfigureCustomFields(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");      
            builder.Property(o => o.Amount).IsRequired();
            builder.Property(o => o.Subtotal).IsRequired();
            builder.Property(o => o.Total).IsRequired();
            builder.Property(o => o.Customer).IsRequired();
            builder.Property(o => o.Items).IsRequired();
            builder.Property(o => o.Addition);
            builder.Property(o => o.Discount);    
        }
    }
}