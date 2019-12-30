using Microsoft.EntityFrameworkCore;
using Pehlivanlar.User;
using System;

namespace Pehlivanlar.Data
{
    public class PehlivanlarDb : DbContext
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=PehlivanlarDb;Trusted_Connection=True;";
        public DbSet<PehUser> PehUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public PehlivanlarDb() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    ID = 1,
                    Name = "Admin",
                    CanChangePassword = true,
                    CanChangePrice = true,
                    CanChangeStock = true
                }
                );

            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   ID = 2,
                   Name = "Personel",
                   CanChangePassword = false,
                   CanChangePrice = false,
                   CanChangeStock = false
               }
               );

            modelBuilder.Entity<PehUser>().HasData(
               new PehUser
               {
                   ID = 1,
                   Name = "Ayvaz",
                   Surname = "Pehlivan",
                   UserName = "admin",
                   Password = new Service.PehUserService().hashPassword("admin"),
                   RoleID = 1,
                   CreatedTime = DateTime.Now,
               }
               );

            //Suppliers are added to database.
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    ID = 1,
                    Name = "Beko",
                    Location = "İstanbul"
                }
                );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    ID = 2,
                    Name = "Vestel",
                    Location = "Manisa"
                }
                );

            //Categories are added to database.
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 1,
                    Name = "Televizyon"
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 2,
                    Name = "Buzdolabı"
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 3,
                    Name = "Çamaşır Makinesi"
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 4,
                    Name = "Bulaşık Makinesi"
                });

            //Products are added to database.
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Code = "Quadro",
                    Color = "Siyah",
                    Properties = "72 Ekran",
                    CategoryID = 1,
                    SupplierID = 1,
                    Stock = 12
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 2,
                    Code = "Smart",
                    Color = "Beyaz",
                    Properties = "72 Ekran",
                    CategoryID = 1,
                    SupplierID = 1,
                    Stock = 3
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 3,
                    Code = "Smart",
                    Color = "Siyah",
                    Properties = "105 Ekran",
                    CategoryID = 1,
                    SupplierID = 2,
                    Stock = 5
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 4,
                    Code = "B1 8459 SMN",
                    Color = "Beyaz",
                    Properties = "465 Litre",
                    CategoryID = 2,
                    SupplierID = 1,
                    Stock = 15
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 5,
                    Code = "B1 8550 SM",
                    Color = "Beyaz",
                    Properties = "550 Litre",
                    CategoryID = 2,
                    SupplierID = 1,
                    Stock = 6
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 6,
                    Code = "854270 MB",
                    Color = "Beyaz",
                    Properties = "270 Litre",
                    CategoryID = 2,
                    SupplierID = 2,
                    Stock = 15
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 7,
                    Code = "BK 6081 L A++",
                    Color = "Beyaz",
                    Properties = "800 Litre",
                    CategoryID = 3,
                    SupplierID = 1,
                    Stock = 17
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 8,
                    Code = "D4 6081 E",
                    Color = "Beyaz",
                    Properties = "800 Devir",
                    CategoryID = 3,
                    SupplierID = 2,
                    Stock = 9
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 9,
                    Code = "BK 8101 EYS",
                    Color = "Inox",
                    Properties = "1000 Devir",
                    CategoryID = 3,
                    SupplierID = 2,
                    Stock = 6
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 10,
                    Code = "BM 3003",
                    Color = "Beyaz",
                    Properties = "3 Programlı",
                    CategoryID = 4,
                    SupplierID = 1,
                    Stock = 11
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 11,
                    Code = "BM 3003 SY",
                    Color = "Siyah",
                    Properties = "3 Programlı",
                    CategoryID = 4,
                    SupplierID = 1,
                    Stock = 3
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 12,
                    Code = "BM 4004",
                    Color = "Beyaz",
                    Properties = "4 Programlı",
                    CategoryID = 4,
                    SupplierID = 2,
                    Stock = 10
                });
        }
    }
}