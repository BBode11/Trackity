﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trackity.Models;

namespace Trackity.Migrations
{
    [DbContext(typeof(ExpenseContext))]
    [Migration("20211016160457_Type")]
    partial class Type
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Trackity.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Cost")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ExpenseId");

                    b.HasIndex("TypeId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            ExpenseId = 1,
                            Cost = 600.0,
                            Date = new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rent Payment",
                            TypeId = "F"
                        },
                        new
                        {
                            ExpenseId = 2,
                            Cost = 8.9900000000000002,
                            Date = new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Netflix",
                            TypeId = "F"
                        },
                        new
                        {
                            ExpenseId = 3,
                            Cost = 42.009999999999998,
                            Date = new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gas",
                            TypeId = "R"
                        },
                        new
                        {
                            ExpenseId = 4,
                            Cost = 21.850000000000001,
                            Date = new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bubba's",
                            TypeId = "R"
                        });
                });

            modelBuilder.Entity("Trackity.Models.Type", b =>
                {
                    b.Property<string>("TypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            TypeId = "F",
                            Name = "Fixed"
                        },
                        new
                        {
                            TypeId = "R",
                            Name = "Recurring"
                        },
                        new
                        {
                            TypeId = "N",
                            Name = "Non-Recurring"
                        },
                        new
                        {
                            TypeId = "W",
                            Name = "Whammy"
                        });
                });

            modelBuilder.Entity("Trackity.Models.Expense", b =>
                {
                    b.HasOne("Trackity.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}