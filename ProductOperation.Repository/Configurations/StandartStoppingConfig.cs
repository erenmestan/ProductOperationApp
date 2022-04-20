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
    public class StandartStoppingConfig : IEntityTypeConfiguration<StandartStopping>
    {
        public void Configure(EntityTypeBuilder<StandartStopping> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();
            builder.Property(x => x.StoppingReason);

            builder.ToTable("StandartStoppings");
        }
    }
}
