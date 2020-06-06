using HubPedidos.v1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HubPedidos.v1.Data.Maps
{
    public abstract class EntityMappings<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {        
            builder.HasKey(e => e.Id);
            builder.Property(e => e.ExternalCode).IsRequired();
            builder.Property(e => e.CreatedAt).IsRequired();
            builder.Property(e => e.LastUpdateAt).IsRequired();

            ConfigureCustomFields(builder);
        }

        public abstract void ConfigureCustomFields(EntityTypeBuilder<TEntity> builder);
    }
}