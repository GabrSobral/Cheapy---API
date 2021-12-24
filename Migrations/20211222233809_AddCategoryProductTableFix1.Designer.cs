﻿// <auto-generated />
using System;
using Cheapy_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cheapy_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211222233809_AddCategoryProductTableFix1")]
    partial class AddCategoryProductTableFix1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Cheapy_API.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Cheapy_API.Models.Category_Product", b =>
                {
                    b.Property<Guid>("Category_Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Product_Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("TEXT");

                    b.HasKey("Category_Id", "Product_Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoriesProducts");
                });

            modelBuilder.Entity("Cheapy_API.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AdvertiserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<float>("Discount")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdvertiserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Cheapy_API.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Cheapy_API.Models.Category_Product", b =>
                {
                    b.HasOne("Cheapy_API.Models.Category", "Category")
                        .WithMany("CategoryProduct")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Cheapy_API.Models.Product", "Product")
                        .WithMany("CategoryProduct")
                        .HasForeignKey("ProductId");

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Cheapy_API.Models.Product", b =>
                {
                    b.HasOne("Cheapy_API.Models.User", "Advertiser")
                        .WithMany("Products")
                        .HasForeignKey("AdvertiserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advertiser");
                });

            modelBuilder.Entity("Cheapy_API.Models.Category", b =>
                {
                    b.Navigation("CategoryProduct");
                });

            modelBuilder.Entity("Cheapy_API.Models.Product", b =>
                {
                    b.Navigation("CategoryProduct");
                });

            modelBuilder.Entity("Cheapy_API.Models.User", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}