﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Entities;

#nullable disable

namespace OnlineShop.Migrations
{
    [DbContext(typeof(OnlineRestaurantContext))]
    partial class OnlineRestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineShop.Entities.Basket", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("OnlineShop.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Categori__19093A0B588CED5D");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineShop.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool?>("HasNuts")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("ProductImage")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("ProductPrice")
                        .HasColumnType("money");

                    b.Property<int?>("Spiciness")
                        .HasColumnType("int");

                    b.HasKey("ProductId")
                        .HasName("PK__Products__B40CC6CDEC6FFC77");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineShop.Entities.Basket", b =>
                {
                    b.HasOne("OnlineShop.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Basktets__Produc__403A8C7D");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineShop.Entities.Product", b =>
                {
                    b.HasOne("OnlineShop.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Products__Catego__3E52440B");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OnlineShop.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
