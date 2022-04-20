using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductOperation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOperation.Repository.Configurations
{
    public class ProductOperationConfig : IEntityTypeConfiguration<ProductionOperation>
    {
        
        public void Configure(EntityTypeBuilder<ProductionOperation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.No).IsRequired().HasMaxLength(50);
            builder.Property(x => x.StartDateTime).IsRequired();
            builder.Property(x => x.EndDateTime).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.StoppingReason);

            builder.ToTable("ProductionOperations");
        }
    }
}
