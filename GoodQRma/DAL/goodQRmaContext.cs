using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GoodQRma.DAL
{
    public class goodQRmaContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public goodQRmaContext() : base("goodQRmaContext") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Event>()
                .HasMany<User>(e => e.Users).WithMany(u => u.Events)
                .Map(t => t.MapLeftKey("EventID").MapRightKey("UserID")
                .ToTable("AttendanceLog"));
        }
    }
} 