﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pehlivanlar.Data;

namespace Pehlivanlar.Migrations
{
    [DbContext(typeof(PehlivanlarDb))]
    [Migration("20191227195042_CatAdded")]
    partial class CatAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        { 
#pragma warning disable 612, 618

            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pehlivanlar.Data.Categories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Televizyon"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Buzdolabı"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Çamaşır Makinesi"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Bulaşık Makinesi"
                        });
                });

            modelBuilder.Entity("Pehlivanlar.Data.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Location = "İstanbul",
                            Name = "Beko"
                        },
                        new
                        {
                            ID = 2,
                            Location = "Manisa",
                            Name = "Vestel"
                        });
                });

            modelBuilder.Entity("Pehlivanlar.User.PehUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("PehUsers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2019, 12, 27, 22, 50, 42, 341, DateTimeKind.Local).AddTicks(4781),
                            Name = "Ayvaz",
                            Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",
                            RoleID = 1,
                            Surname = "Pehlivan",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Pehlivanlar.User.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanChangePassword")
                        .HasColumnType("bit");

                    b.Property<bool>("CanChangePrice")
                        .HasColumnType("bit");

                    b.Property<bool>("CanChangeStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CanChangePassword = true,
                            CanChangePrice = true,
                            CanChangeStock = true,
                            Name = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            CanChangePassword = false,
                            CanChangePrice = false,
                            CanChangeStock = false,
                            Name = "Personel"
                        });
                });

            modelBuilder.Entity("Pehlivanlar.User.PehUser", b =>
                {
                    b.HasOne("Pehlivanlar.User.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
