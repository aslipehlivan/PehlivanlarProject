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
                   CreatedTime = DateTime.Now,
                   RoleID = 1
               }
           );



        }
    }

    
   


}
