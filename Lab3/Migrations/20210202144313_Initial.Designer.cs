﻿// <auto-generated />
using System;
using Lab3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab3.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20210202144313_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Lab3.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            name = "Family"
                        },
                        new
                        {
                            CategoryId = 2,
                            name = "Friend"
                        },
                        new
                        {
                            CategoryId = 3,
                            name = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            name = "Other"
                        });
                });

            modelBuilder.Entity("Lab3.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = 1,
                            dateAdded = new DateTime(2021, 2, 2, 9, 43, 12, 959, DateTimeKind.Local).AddTicks(3404),
                            email = "bruce.wayne@domain.com",
                            firstName = "Bruce",
                            lastName = "Wayne",
                            phone = "416-123-4567"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = 1,
                            dateAdded = new DateTime(2021, 2, 2, 9, 43, 12, 962, DateTimeKind.Local).AddTicks(8392),
                            email = "peter.parker@domain.com",
                            firstName = "Peter",
                            lastName = "Parker",
                            phone = "647-123-4567"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = 3,
                            dateAdded = new DateTime(2021, 2, 2, 9, 43, 12, 962, DateTimeKind.Local).AddTicks(8427),
                            email = "diana.prince@domain.com",
                            firstName = "Diana",
                            lastName = "Prince",
                            phone = "647-233-4567"
                        });
                });

            modelBuilder.Entity("Lab3.Models.Contact", b =>
                {
                    b.HasOne("Lab3.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });
#pragma warning restore 612, 618
        }
    }
}
