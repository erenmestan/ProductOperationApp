// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductOperation.Repository;

#nullable disable

namespace ProductOperation.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductOperation.Core.Models.ProductionOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("StoppingReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductionOperations", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            No = "İş 1",
                            StartDateTime = new DateTime(2020, 5, 23, 7, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            No = "İş 2",
                            StartDateTime = new DateTime(2020, 5, 23, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            No = "İş 3",
                            StartDateTime = new DateTime(2020, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 13, 45, 0, 0, DateTimeKind.Unspecified),
                            No = "Duruş 1",
                            StartDateTime = new DateTime(2020, 5, 23, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false,
                            StoppingReason = "Arıza",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            No = "İş 4",
                            StartDateTime = new DateTime(2020, 5, 23, 13, 45, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ProductOperation.Core.Models.StandartStopping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StoppingReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("StandartStoppings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            StartDateTime = new DateTime(2020, 5, 23, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            StoppingReason = "Çay Molası",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            StartDateTime = new DateTime(2020, 5, 23, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            StoppingReason = "Yemek Molası",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndDateTime = new DateTime(2020, 5, 23, 15, 15, 0, 0, DateTimeKind.Unspecified),
                            StartDateTime = new DateTime(2020, 5, 23, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StoppingReason = "Çay Molası",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
