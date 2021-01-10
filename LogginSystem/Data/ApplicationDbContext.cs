using LogginSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogginSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<ContactForm> ContactForms { get; set; }
      

//1)Enable Migrations

//2)Add-Migration "PostMigration"

//3)Update-Database
    }
}
