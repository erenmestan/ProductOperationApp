using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductOperation.Core.Models;

namespace ProductOperation.Repository.Configurations
{
    public class StandartStoppingConfig : IEntityTypeConfiguration<StandartStopping>
    {
        public void Configure(EntityTypeBuilder<StandartStopping> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.StartDateTime).IsRequired();
            builder.Property(x => x.EndDateTime).IsRequired();
            builder.Property(x => x.StoppingReason);

            builder.ToTable("StandartStoppings");
        }
    }
}
