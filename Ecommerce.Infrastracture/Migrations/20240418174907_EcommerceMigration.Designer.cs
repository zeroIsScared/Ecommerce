﻿// <auto-generated />
using System;
using Ecommerce.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Infrastracture.Migrations
{
    [DbContext(typeof(EcommerceDBContext))]
    [Migration("20240418174907_EcommerceMigration")]
    partial class EcommerceMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Domain.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("HouseNumber")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<long>("LocalityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("LocalityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Currency", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Symbol")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.District", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Locality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<long>("DistrictId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Region")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Localities");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Property", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<long>("CurrencyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("UserId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.PropertyDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int?>("AuthorType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int?>("BuildingType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Floor")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int?>("FloorsNumber")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int?>("LandType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("LivingArea")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int?>("ParkingType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<long>("PropertyId")
                        .HasColumnType("bigint");

                    b.Property<int?>("RoomNumber")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int?>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("PropertyDetails");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.PropertyPhoto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<long>("PropertyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyPhoto");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.PropertyUtility", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<long>("PropertyId")
                        .HasColumnType("bigint");

                    b.Property<long>("UtilityId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UtilityId");

                    b.ToTable("PropertyUtilities");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.UserFavorite", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<long>("PropertyId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFavorites");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Utility", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ForAppartments")
                        .HasColumnType("bit");

                    b.Property<bool>("ForHouses")
                        .HasColumnType("bit");

                    b.Property<bool>("ForLands")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilities");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Address", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Locality", "Locality")
                        .WithMany("Properties")
                        .HasForeignKey("LocalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locality");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Locality", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.District", "District")
                        .WithMany("Localities")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Property", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Address", "Address")
                        .WithMany("Properties")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Domain.Entities.Currency", "Currency")
                        .WithMany("Properties")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Domain.Entities.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Currency");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.PropertyDetail", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Property", "Property")
                        .WithOne("Details")
                        .HasForeignKey("Ecommerce.Domain.Entities.PropertyDetail", "PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.PropertyPhoto", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Property", "Property")
                        .WithMany("Photos")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.PropertyUtility", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Property", "Property")
                        .WithMany("Utilities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Domain.Entities.Utility", "Utility")
                        .WithMany("Properties")
                        .HasForeignKey("UtilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("Utility");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.UserFavorite", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Property", "Property")
                        .WithMany("Favorites")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Domain.Entities.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Address", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Currency", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.District", b =>
                {
                    b.Navigation("Localities");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Locality", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Property", b =>
                {
                    b.Navigation("Details")
                        .IsRequired();

                    b.Navigation("Favorites");

                    b.Navigation("Photos");

                    b.Navigation("Utilities");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.User", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Utility", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
