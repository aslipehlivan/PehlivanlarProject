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
    [Migration("20191230181421_CatChanged")]
    partial class CatChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pehlivanlar.Data.Category", b =>
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

            modelBuilder.Entity("Pehlivanlar.Data.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Properties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Code = "Quadro",
                            Color = "Siyah",
                            Properties = "72 Ekran",
                            Stock = 12,
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            Code = "Smart",
                            Color = "Beyaz",
                            Properties = "72 Ekran",
                            Stock = 3,
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 1,
                            Code = "Smart",
                            Color = "Siyah",
                            Properties = "105 Ekran",
                            Stock = 5,
                            SupplierID = 2
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 2,
                            Code = "B1 8459 SMN",
                            Color = "Beyaz",
                            Properties = "465 Litre",
                            Stock = 15,
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 2,
                            Code = "B1 8550 SM",
                            Color = "Beyaz",
                            Properties = "550 Litre",
                            Stock = 6,
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 2,
                            Code = "854270 MB",
                            Color = "Beyaz",
                            Properties = "270 Litre",
                            Stock = 15,
                            SupplierID = 2
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 3,
                            Code = "BK 6081 L A++",
                            Color = "Beyaz",
                            Properties = "800 Litre",
                            Stock = 17,
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 3,
                            Code = "D4 6081 E",
                            Color = "Beyaz",
                            Properties = "800 Devir",
                            Stock = 9,
                            SupplierID = 2
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 3,
                            Code = "BK 8101 EYS",
                            Color = "Inox",
                            Properties = "1000 Devir",
                            Stock = 6,
                            SupplierID = 2
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 4,
                            Code = "BM 3003",
                            Color = "Beyaz",
                            Properties = "3 Programlı",
                            Stock = 11,
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 11,
                            CategoryID = 4,
                            Code = "BM 3003 SY",
                            Color = "Siyah",
                            Properties = "3 Programlı",
                            Stock = 3,
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 12,
                            CategoryID = 4,
                            Code = "BM 4004",
                            Color = "Beyaz",
                            Properties = "4 Programlı",
                            Stock = 10,
                            SupplierID = 2
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
                            CreatedTime = new DateTime(2019, 12, 30, 21, 14, 21, 22, DateTimeKind.Local).AddTicks(7292),
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
