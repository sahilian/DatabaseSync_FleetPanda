﻿// <auto-generated />
using System;
using DatabaseSync.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseSync.Migrations.TargetDb
{
    [DbContext(typeof(TargetDbContext))]
    [Migration("20241027123404_fixestarget")]
    partial class fixestarget
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("DatabaseSync.Models.Target.SyncLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Changes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SyncTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SyncLogs");
                });

            modelBuilder.Entity("DatabaseSync.Models.Target.TargetCustomer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DatabaseSync.Models.Target.TargetLocation", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DatabaseSync.Models.Target.TargetLocation", b =>
                {
                    b.HasOne("DatabaseSync.Models.Target.TargetCustomer", "Customer")
                        .WithMany("Locations")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DatabaseSync.Models.Target.TargetCustomer", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}