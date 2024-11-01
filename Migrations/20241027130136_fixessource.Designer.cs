﻿// <auto-generated />
using System;
using DatabaseSync.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseSync.Migrations
{
    [DbContext(typeof(SourceDbContext))]
    [Migration("20241027130136_fixessource")]
    partial class fixessource
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatabaseSync.Models.Source.SourceCustomer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Email = "sapana@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9301),
                            Name = "Sapana Shrestha",
                            Phone = "9811111111"
                        },
                        new
                        {
                            CustomerID = 2,
                            Email = "sahil@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9353),
                            Name = "Sahil Shrestha",
                            Phone = "9822222222"
                        },
                        new
                        {
                            CustomerID = 3,
                            Email = "aayush@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9354),
                            Name = "Aayush Khadka",
                            Phone = "9833333333"
                        },
                        new
                        {
                            CustomerID = 4,
                            Email = "sneha@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9355),
                            Name = "Sneha Sharma",
                            Phone = "9844444444"
                        },
                        new
                        {
                            CustomerID = 5,
                            Email = "rajesh@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9356),
                            Name = "Rajesh Karki",
                            Phone = "9855555555"
                        },
                        new
                        {
                            CustomerID = 6,
                            Email = "ramesh@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9357),
                            Name = "Ramesh Bhandari",
                            Phone = "9866666666"
                        },
                        new
                        {
                            CustomerID = 7,
                            Email = "nabin@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9358),
                            Name = "Nabin Rijal",
                            Phone = "9877777777"
                        },
                        new
                        {
                            CustomerID = 8,
                            Email = "sita@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9359),
                            Name = "Sita Rai",
                            Phone = "9888888888"
                        },
                        new
                        {
                            CustomerID = 9,
                            Email = "pratiksha@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9360),
                            Name = "Pratiksha Joshi",
                            Phone = "9899999999"
                        },
                        new
                        {
                            CustomerID = 10,
                            Email = "bikash@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9361),
                            Name = "Bikash Acharya",
                            Phone = "9800000001"
                        },
                        new
                        {
                            CustomerID = 11,
                            Email = "santosh@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9362),
                            Name = "Santosh Yadav",
                            Phone = "9800000002"
                        },
                        new
                        {
                            CustomerID = 12,
                            Email = "niraj@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9363),
                            Name = "Niraj Gurung",
                            Phone = "9800000003"
                        },
                        new
                        {
                            CustomerID = 13,
                            Email = "kriti@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9364),
                            Name = "Kriti Maharjan",
                            Phone = "9800000004"
                        },
                        new
                        {
                            CustomerID = 14,
                            Email = "binita@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9365),
                            Name = "Binita Kunwar",
                            Phone = "9800000005"
                        },
                        new
                        {
                            CustomerID = 15,
                            Email = "saroj@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9366),
                            Name = "Saroj Luitel",
                            Phone = "9800000006"
                        },
                        new
                        {
                            CustomerID = 16,
                            Email = "asmita@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9367),
                            Name = "Asmita Lama",
                            Phone = "9800000007"
                        },
                        new
                        {
                            CustomerID = 17,
                            Email = "kiran@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9368),
                            Name = "Kiran Sapkota",
                            Phone = "9800000008"
                        },
                        new
                        {
                            CustomerID = 18,
                            Email = "bhawana@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9369),
                            Name = "Bhawana Adhikari",
                            Phone = "9800000009"
                        },
                        new
                        {
                            CustomerID = 19,
                            Email = "arjun@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9370),
                            Name = "Arjun Adhikari",
                            Phone = "9800000010"
                        },
                        new
                        {
                            CustomerID = 20,
                            Email = "mina@gmail.com",
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9371),
                            Name = "Mina Magar",
                            Phone = "9800000011"
                        });
                });

            modelBuilder.Entity("DatabaseSync.Models.Source.SourceLocation", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasKey("LocationID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationID = 1,
                            Address = "Kathmandu",
                            CustomerID = 1,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9459)
                        },
                        new
                        {
                            LocationID = 2,
                            Address = "Bhaktapur",
                            CustomerID = 1,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9460)
                        },
                        new
                        {
                            LocationID = 3,
                            Address = "Dang",
                            CustomerID = 2,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9461)
                        },
                        new
                        {
                            LocationID = 4,
                            Address = "Chitwan",
                            CustomerID = 3,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9462)
                        },
                        new
                        {
                            LocationID = 5,
                            Address = "Butwal",
                            CustomerID = 3,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9463)
                        },
                        new
                        {
                            LocationID = 6,
                            Address = "Dharan",
                            CustomerID = 4,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9464)
                        },
                        new
                        {
                            LocationID = 7,
                            Address = "Janakpur",
                            CustomerID = 5,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9465)
                        },
                        new
                        {
                            LocationID = 8,
                            Address = "Nepalgunj",
                            CustomerID = 6,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9465)
                        },
                        new
                        {
                            LocationID = 9,
                            Address = "Birgunj",
                            CustomerID = 7,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9466)
                        },
                        new
                        {
                            LocationID = 10,
                            Address = "Hetauda",
                            CustomerID = 7,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9467)
                        },
                        new
                        {
                            LocationID = 11,
                            Address = "Gorkha",
                            CustomerID = 8,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9468)
                        },
                        new
                        {
                            LocationID = 12,
                            Address = "Lamjung",
                            CustomerID = 9,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9469)
                        },
                        new
                        {
                            LocationID = 13,
                            Address = "Palpa",
                            CustomerID = 10,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9470)
                        },
                        new
                        {
                            LocationID = 14,
                            Address = "Syangja",
                            CustomerID = 10,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9470)
                        },
                        new
                        {
                            LocationID = 15,
                            Address = "Baglung",
                            CustomerID = 11,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9471)
                        },
                        new
                        {
                            LocationID = 16,
                            Address = "Damauli",
                            CustomerID = 12,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9472)
                        },
                        new
                        {
                            LocationID = 17,
                            Address = "Tanahun",
                            CustomerID = 13,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9473)
                        },
                        new
                        {
                            LocationID = 18,
                            Address = "Ilam",
                            CustomerID = 14,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9474)
                        },
                        new
                        {
                            LocationID = 19,
                            Address = "Jhapa",
                            CustomerID = 15,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9475)
                        },
                        new
                        {
                            LocationID = 20,
                            Address = "Kavre",
                            CustomerID = 16,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9476)
                        },
                        new
                        {
                            LocationID = 21,
                            Address = "Banepa",
                            CustomerID = 16,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9477)
                        },
                        new
                        {
                            LocationID = 22,
                            Address = "Sindhuli",
                            CustomerID = 17,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9477)
                        },
                        new
                        {
                            LocationID = 23,
                            Address = "Nuwakot",
                            CustomerID = 18,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9478)
                        },
                        new
                        {
                            LocationID = 24,
                            Address = "Ramechhap",
                            CustomerID = 19,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9479)
                        },
                        new
                        {
                            LocationID = 25,
                            Address = "Dolakha",
                            CustomerID = 20,
                            LastModified = new DateTime(2024, 10, 27, 18, 46, 35, 974, DateTimeKind.Local).AddTicks(9480)
                        });
                });

            modelBuilder.Entity("DatabaseSync.Models.Source.SourceLocation", b =>
                {
                    b.HasOne("DatabaseSync.Models.Source.SourceCustomer", "Customer")
                        .WithMany("Locations")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DatabaseSync.Models.Source.SourceCustomer", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
