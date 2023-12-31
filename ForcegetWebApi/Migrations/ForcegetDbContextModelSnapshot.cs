﻿// <auto-generated />
using ForcegetWebApi.Dataaccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ForcegetWebApi.Migrations
{
    [DbContext(typeof(ForcegetDbContext))]
    partial class ForcegetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ForcegetWebApi.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "İzmir"
                        });
                });

            modelBuilder.Entity("ForcegetWebApi.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = 2,
                            Name = "China"
                        });
                });

            modelBuilder.Entity("ForcegetWebApi.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("Currency")
                        .HasColumnType("integer");

                    b.Property<int>("Incoterm")
                        .HasColumnType("integer");

                    b.Property<int>("Mode")
                        .HasColumnType("integer");

                    b.Property<int>("MovementType")
                        .HasColumnType("integer");

                    b.Property<int>("PackageType")
                        .HasColumnType("integer");

                    b.Property<int>("Unit1")
                        .HasColumnType("integer");

                    b.Property<int>("Unit2")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ForcegetWebApi.Entities.City", b =>
                {
                    b.HasOne("ForcegetWebApi.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ForcegetWebApi.Entities.Order", b =>
                {
                    b.HasOne("ForcegetWebApi.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("ForcegetWebApi.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
