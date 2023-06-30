﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsTestTask.Models;

#nullable disable

namespace ProductsTestTask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230629122353_InitDb")]
    partial class InitDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductsTestTask.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Овощи"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Фрукты"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Мясные продукты"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Молочные продукты"
                        });
                });

            modelBuilder.Entity("ProductsTestTask.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Помидоры"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Огурцы"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Яблоки"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Бананы"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Филе куриное"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Мясо индейки"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Молоко"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Творог"
                        });
                });

            modelBuilder.Entity("ProductsTestTask.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            ProductId = 8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
