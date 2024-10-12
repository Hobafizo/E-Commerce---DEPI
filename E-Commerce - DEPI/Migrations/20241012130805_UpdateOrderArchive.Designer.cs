﻿// <auto-generated />
using System;
using E_Commerce___DEPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce___DEPI.Migrations
{
    [DbContext(typeof(DbIntities))]
    [Migration("20241012130805_UpdateOrderArchive")]
    partial class UpdateOrderArchive
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("Num")
                        .HasColumnType("int");

                    b.Property<int?>("ShippmentCitiesId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.HasIndex("ShippmentCitiesId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.FrameMat", b =>
                {
                    b.Property<int>("No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("No"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("No");

                    b.ToTable("FrameMats");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.OrderArchive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderArchives");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.OrderdItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("Order_id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderdItems");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CatId")
                        .HasColumnType("int");

                    b.Property<float>("Depth")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("FrameMatNo")
                        .HasColumnType("int");

                    b.Property<int?>("FrameMateNo")
                        .HasColumnType("int");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<int?>("UpholsteryMatNo")
                        .HasColumnType("int");

                    b.Property<int?>("Upholstery_mat_no")
                        .HasColumnType("int");

                    b.Property<float>("Width")
                        .HasColumnType("real");

                    b.Property<string>("img1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img6")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.HasIndex("FrameMatNo");

                    b.HasIndex("UpholsteryMatNo");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.ShippmentCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShppmentFee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShippmentCities");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.UpholsteryMat", b =>
                {
                    b.Property<int>("No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("No"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("No");

                    b.ToTable("UpholsteryMats");
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.HasOne("E_Commerce___DEPI.Models.Customer", "Customer")
                        .WithOne("Address")
                        .HasForeignKey("Address", "CustomerId");

                    b.HasOne("E_Commerce___DEPI.Models.ShippmentCity", "ShippmentCities")
                        .WithMany()
                        .HasForeignKey("ShippmentCitiesId");

                    b.Navigation("Customer");

                    b.Navigation("ShippmentCities");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.CartItem", b =>
                {
                    b.HasOne("E_Commerce___DEPI.Models.Customer", "Customer")
                        .WithMany("CartItems")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce___DEPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Feedback", b =>
                {
                    b.HasOne("E_Commerce___DEPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("E_Commerce___DEPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Order", b =>
                {
                    b.HasOne("Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId");

                    b.HasOne("E_Commerce___DEPI.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.OrderArchive", b =>
                {
                    b.HasOne("E_Commerce___DEPI.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.OrderdItem", b =>
                {
                    b.HasOne("E_Commerce___DEPI.Models.Order", "Order")
                        .WithMany("OrderdItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("E_Commerce___DEPI.Models.Product", "Product")
                        .WithMany("orderdItems")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Product", b =>
                {
                    b.HasOne("E_Commerce___DEPI.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CatId");

                    b.HasOne("E_Commerce___DEPI.Models.FrameMat", null)
                        .WithMany("Products")
                        .HasForeignKey("FrameMatNo");

                    b.HasOne("E_Commerce___DEPI.Models.UpholsteryMat", "UpholsteryMat")
                        .WithMany("Products")
                        .HasForeignKey("UpholsteryMatNo");

                    b.Navigation("Category");

                    b.Navigation("UpholsteryMat");
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Customer", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("CartItems");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.FrameMat", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Order", b =>
                {
                    b.Navigation("OrderdItems");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.Product", b =>
                {
                    b.Navigation("orderdItems");
                });

            modelBuilder.Entity("E_Commerce___DEPI.Models.UpholsteryMat", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
