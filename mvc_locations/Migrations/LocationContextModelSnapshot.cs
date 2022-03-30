﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc_locations.Data;

#nullable disable

namespace mvc_locations.Migrations
{
    [DbContext(typeof(LocationContext))]
    partial class LocationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("mvc_locations.Models.City", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("city_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.Property<decimal>("latitude")
                        .HasColumnType("decimal(9,6)");

                    b.Property<decimal>("longitude")
                        .HasColumnType("decimal(9,6)");

                    b.HasKey("id");

                    b.HasIndex("country_id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            id = 1,
                            city_name = "Đakovo",
                            country_id = 1,
                            latitude = 45.3100m,
                            longitude = 18.4098m
                        },
                        new
                        {
                            id = 2,
                            city_name = "Split",
                            country_id = 1,
                            latitude = 43.5147m,
                            longitude = 16.4435m
                        },
                        new
                        {
                            id = 3,
                            city_name = "São Paulo",
                            country_id = 3,
                            latitude = 23.5558m,
                            longitude = 46.6396m
                        },
                        new
                        {
                            id = 4,
                            city_name = "Rio de Janeiro",
                            country_id = 3,
                            latitude = 22.9068m,
                            longitude = 43.1729m
                        },
                        new
                        {
                            id = 5,
                            city_name = "Marseille",
                            country_id = 2,
                            latitude = 43.2965m,
                            longitude = 5.3698m
                        },
                        new
                        {
                            id = 6,
                            city_name = "Lille",
                            country_id = 2,
                            latitude = 50.6292m,
                            longitude = 3.0573m
                        });
                });

            modelBuilder.Entity("mvc_locations.Models.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("country_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("country_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_name_eng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            id = 1,
                            country_code = "+385",
                            country_name = "Hrvatska",
                            country_name_eng = "Croatia"
                        },
                        new
                        {
                            id = 2,
                            country_code = "+33",
                            country_name = "Francuska",
                            country_name_eng = "France"
                        },
                        new
                        {
                            id = 3,
                            country_code = "+55",
                            country_name = "Brazil",
                            country_name_eng = "Brazil"
                        });
                });

            modelBuilder.Entity("mvc_locations.Models.City", b =>
                {
                    b.HasOne("mvc_locations.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
