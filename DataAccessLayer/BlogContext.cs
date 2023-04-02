using DataAccessLayer.Configuration;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BlogContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutConfiguration()).ApplyConfiguration(new CategoryConfiguration()).ApplyConfiguration(new ContactConfiguration()).ApplyConfiguration(new ContentConfiguration()).ApplyConfiguration(new HeadingConfiguration()).ApplyConfiguration(new WriterConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q56AEMU\MSSQLKD14;Initial Catalog=BlogDb;user Id=sa;Password=Beste1998.");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
