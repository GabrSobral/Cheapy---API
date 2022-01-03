﻿// <auto-generated />
using System;
using Cheapy_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cheapy_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoriesProducts");
                });

            modelBuilder.Entity("Cheapy_API.Models.Feedback", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Recomendation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Cheapy_API.Models.PaymentHistory", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PaidAt")
                        .HasColumnType("TEXT");

                    b.Property<float>("PaidValue")
                        .HasColumnType("REAL");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentHistories");
                });

            modelBuilder.Entity("Cheapy_API.Models.Photos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Photos");
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

                    b.Property<string>("ThumbUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdvertiserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Cheapy_API.Models.ShoppingCart", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCarts");
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
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cheapy_API.Models.Product", "Product")
                        .WithMany("CategoryProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Cheapy_API.Models.Feedback", b =>
                {
                    b.HasOne("Cheapy_API.Models.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cheapy_API.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cheapy_API.Models.PaymentHistory", b =>
                {
                    b.HasOne("Cheapy_API.Models.Product", "Product")
                        .WithMany("PaymentsHistory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cheapy_API.Models.User", "User")
                        .WithMany("PaymentsHistory")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cheapy_API.Models.Photos", b =>
                {
                    b.HasOne("Cheapy_API.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Cheapy_API.Models.ShoppingCart", b =>
                {
                    b.HasOne("Cheapy_API.Models.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cheapy_API.Models.User", "User")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cheapy_API.Models.Category", b =>
                {
                    b.Navigation("CategoryProduct");
                });

            modelBuilder.Entity("Cheapy_API.Models.Product", b =>
                {
                    b.Navigation("CategoryProduct");

                    b.Navigation("Feedbacks");

                    b.Navigation("PaymentsHistory");

                    b.Navigation("Photos");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("Cheapy_API.Models.User", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("PaymentsHistory");

                    b.Navigation("Products");

                    b.Navigation("ShoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
