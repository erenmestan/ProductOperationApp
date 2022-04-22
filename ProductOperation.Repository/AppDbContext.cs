using Microsoft.EntityFrameworkCore;
using ProductOperation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductOperation.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductionOperation> ProductionOperations { get; set; }
        public DbSet<StandartStopping> StandartStoppings { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StandartStopping>().HasData(new StandartStopping()
            {
                Id = 1,
                StartDateTime = new DateTime(2020, 5, 23, 10, 00, 0),
                EndDateTime = new DateTime(2020, 5, 23, 10, 15, 0),
                StoppingReason ="Çay Molası",

            }, new StandartStopping()
            {
                Id = 2,
                StartDateTime = new DateTime(2020, 5, 23, 12, 00, 0),
                EndDateTime = new DateTime(2020, 5, 23, 12, 30, 0),
                StoppingReason ="Yemek Molası",

            }, new StandartStopping()
            {
                Id = 3,
                StartDateTime = new DateTime(2020, 5, 23, 15, 00, 0),
                EndDateTime = new DateTime(2020, 5, 23, 15, 15, 0),
                StoppingReason ="Çay Molası",
            }
            );
            modelBuilder.Entity<ProductionOperation>().HasData(new ProductionOperation()
            {
                Id = 1,
                No="İş 1",
                StartDateTime = new DateTime(2020, 5, 23, 7, 30, 0),
                EndDateTime = new DateTime(2020, 5, 23, 8, 30, 0),
                Status = true,
                StoppingReason =null,

            }, new ProductionOperation()
            {
                Id = 2,
                No="İş 2",
                StartDateTime = new DateTime(2020, 5, 23, 8, 30, 0),
                EndDateTime = new DateTime(2020, 5, 23, 12, 00, 0),
                Status = true,
                StoppingReason =null,
            }, new ProductionOperation()
            {
                Id = 3,
                No="İş 3",
                StartDateTime = new DateTime(2020, 5, 23, 12, 00, 0),
                EndDateTime = new DateTime(2020, 5, 23, 13, 00, 0),
                Status = true,
                StoppingReason =null,

            }, new ProductionOperation()
            {
                Id = 4,
                No="Duruş 1",
                StartDateTime = new DateTime(2020, 5, 23, 13, 00, 0),
                EndDateTime = new DateTime(2020, 5, 23, 13, 45, 0),
                Status = false,
                StoppingReason ="Arıza",

            }, new ProductionOperation()
            {
                Id = 5,
                No="İş 4",
                StartDateTime = new DateTime(2020, 5, 23, 13, 45, 0),
                EndDateTime = new DateTime(2020, 5, 23, 17, 30, 0),
                Status = true,
                StoppingReason =null,

            }
           );

        }
    }
}
