﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PotionShop.Models;

#nullable disable

namespace PotionShop.Migrations
{
    [DbContext(typeof(PotionShopDbContext))]
    [Migration("20240520234557_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PotionShop.Models.Entities.Potion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PowerLevel")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseLocation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Potions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Charmcaster Elixir",
                            PowerLevel = 1,
                            Stock = 50,
                            Type = 4,
                            WarehouseLocation = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
