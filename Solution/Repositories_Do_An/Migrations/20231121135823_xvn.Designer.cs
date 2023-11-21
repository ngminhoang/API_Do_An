﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repositories_Do_An.DBcontext_vs_Entities;

#nullable disable

namespace Repositories_Do_An.Migrations
{
    [DbContext(typeof(CFcontext))]
    [Migration("20231121135823_xvn")]
    partial class xvn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Admin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("AvatarImageLink")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateCreatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<bool?>("able")
                        .HasColumnType("boolean");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.AppRate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RateId"));

                    b.Property<DateTime?>("CommentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Commnent")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int?>("Rate")
                        .HasColumnType("integer");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("RateId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRate");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Bussiness", b =>
                {
                    b.Property<int>("BussinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BussinessId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("BusinessLicenseNumber")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("BusinessName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("BusinessWebsite")
                        .HasColumnType("text");

                    b.Property<string>("BussinessPassword")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ContactEmail")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool?>("CoopStatus")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DateCreatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("BussinessId");

                    b.HasIndex("RoleId");

                    b.ToTable("Bussiness");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Contaction", b =>
                {
                    b.Property<int>("ContactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ContactionId"));

                    b.Property<string>("Comntent")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.HasKey("ContactionId");

                    b.ToTable("Contaction");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Counting", b =>
                {
                    b.Property<int>("CountingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CountingId"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<double?>("Values")
                        .HasColumnType("double precision");

                    b.HasKey("CountingId");

                    b.ToTable("Counting");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Customer", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("AvatarImageLink")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateCreatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<bool?>("able")
                        .HasColumnType("boolean");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Driver", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("AvatarImageLink")
                        .HasColumnType("text");

                    b.Property<string>("BackIdentifyImageLink")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateCreatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FrontIdentifyImageLink")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<bool?>("able")
                        .HasColumnType("boolean");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.DriverRate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RateId"));

                    b.Property<DateTime?>("CommentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Commnent")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int?>("DriverId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int?>("Rate")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("RateId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DriverId");

                    b.HasIndex("OrderId");

                    b.ToTable("DriverRate");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InvoiceId"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("InvoiceId");

                    b.HasIndex("OrderId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Message", b =>
                {
                    b.Property<int>("MessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessId"));

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<bool?>("CheckRead")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int?>("StaffId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("MessId");

                    b.HasIndex("RoleId");

                    b.HasIndex("StaffId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<DateOnly?>("ArrivedDate")
                        .HasColumnType("date");

                    b.Property<int?>("BussinessId")
                        .HasColumnType("integer");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("DetailPositionCome")
                        .HasColumnType("text");

                    b.Property<string>("DetailPositionGo")
                        .HasColumnType("text");

                    b.Property<string>("DistrictCome")
                        .HasColumnType("text");

                    b.Property<string>("DistrictGo")
                        .HasColumnType("text");

                    b.Property<int?>("OVIId")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("OrderedDate")
                        .HasColumnType("date");

                    b.Property<string>("ProvinceCome")
                        .HasColumnType("text");

                    b.Property<string>("ProvinceGo")
                        .HasColumnType("text");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<double?>("TotalAmount")
                        .HasColumnType("double precision");

                    b.Property<string>("WardCome")
                        .HasColumnType("text");

                    b.Property<string>("WardGo")
                        .HasColumnType("text");

                    b.Property<string>("orderName")
                        .HasColumnType("text");

                    b.HasKey("OrderId");

                    b.HasIndex("BussinessId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OVIId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderItemId"));

                    b.Property<string>("ItemDescription")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("ItemImage")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ItemName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double?>("MassPerUnit")
                        .HasColumnType("double precision");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<double?>("PricePerUnit")
                        .HasColumnType("double precision");

                    b.Property<int?>("Quantity")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<double?>("WeightPerUnit")
                        .HasColumnType("double precision");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderStatusId"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<int?>("StatusId")
                        .HasColumnType("integer");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("integer");

                    b.HasKey("OrderStatusId");

                    b.HasIndex("OrderId");

                    b.HasIndex("StatusId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.OwnedVehicleInfor", b =>
                {
                    b.Property<int>("OVIId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OVIId"));

                    b.Property<double?>("Cargo")
                        .HasColumnType("double precision");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int?>("DriverId")
                        .HasColumnType("integer");

                    b.Property<double?>("FuelEfficiency")
                        .HasColumnType("double precision");

                    b.Property<string>("LicenceImageLink")
                        .HasColumnType("text");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("integer");

                    b.HasKey("OVIId");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("OwnedVehicleInfor");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PositionId"));

                    b.Property<string>("District")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Number")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Province")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Ward")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("PositionId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Staff", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("AvatarImageLink")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateCreatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdatedAccount")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<bool?>("able")
                        .HasColumnType("boolean");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StatusId"));

                    b.Property<string>("StatusName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VehicleId"));

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("VehicleName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("Wheel")
                        .HasColumnType("integer");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WarehouseId"));

                    b.Property<int?>("BussinessId")
                        .HasColumnType("integer");

                    b.Property<string>("District")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Number")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Province")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Ward")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("WarehouseDescription")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("WarehouseName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("WarehouseId");

                    b.HasIndex("BussinessId");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.WishedAcceptedDriverList", b =>
                {
                    b.Property<int>("WADLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WADLId"));

                    b.Property<int?>("OVIId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("WADLId");

                    b.HasIndex("OVIId");

                    b.HasIndex("OrderId");

                    b.ToTable("WishedAcceptedDriverList");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Admin", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.AppRate", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Bussiness", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Customer", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Driver", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.DriverRate", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Driver", "driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("customer");

                    b.Navigation("driver");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Invoice", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Message", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Staff", "staff")
                        .WithMany()
                        .HasForeignKey("StaffId");

                    b.Navigation("role");

                    b.Navigation("staff");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Order", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Bussiness", "bussiness")
                        .WithMany()
                        .HasForeignKey("BussinessId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.OwnedVehicleInfor", "ownedVehicleInfor")
                        .WithMany()
                        .HasForeignKey("OVIId");

                    b.Navigation("bussiness");

                    b.Navigation("customer");

                    b.Navigation("ownedVehicleInfor");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.OrderItem", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.OrderStatus", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Status", "StatusType")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Warehouse", "warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId");

                    b.Navigation("StatusType");

                    b.Navigation("order");

                    b.Navigation("warehouse");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.OwnedVehicleInfor", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Driver", "driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Vehicle", "vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");

                    b.Navigation("driver");

                    b.Navigation("vehicle");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Staff", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.Warehouse", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Bussiness", "bussiness")
                        .WithMany()
                        .HasForeignKey("BussinessId");

                    b.Navigation("bussiness");
                });

            modelBuilder.Entity("Repositories_Do_An.DBcontext_vs_Entities.WishedAcceptedDriverList", b =>
                {
                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.OwnedVehicleInfor", "ownedVehicleInfor")
                        .WithMany()
                        .HasForeignKey("OVIId");

                    b.HasOne("Repositories_Do_An.DBcontext_vs_Entities.Order", "order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("order");

                    b.Navigation("ownedVehicleInfor");
                });
#pragma warning restore 612, 618
        }
    }
}
