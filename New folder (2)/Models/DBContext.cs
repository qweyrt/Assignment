using Microsoft.EntityFrameworkCore;
using Users;
using Books;
using Category;
using Request;
using RequestDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models {
    public class DBContext : DbContext {
        public DBContext() { }
        public DBContext(DbContextOptions<DBContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<BooksModel>().HasKey(s => s.BookID);
            modelBuilder.Entity<RequestModel>().HasKey(s => s.RequestID);
            modelBuilder.Entity<CategoryModel>().HasKey(s => s.CategoryID);
            modelBuilder.Entity<RequestDetailsModel>().HasKey(s => (s.RequestID, s.BookID));
            modelBuilder.Entity<UsersModel>().HasKey(s => s.UserID);
            
            modelBuilder.Entity<BooksModel>()
                .HasOne(s => s.Category)
                .WithMany(s => s.Books)
                .HasForeignKey(s => s.CategoryID);
            modelBuilder.Entity<RequestModel>()
                .HasOne(s => s.Users)
                .WithMany(s => s.Books)
                .HasForeignKey(s => s.UserID);
            modelBuilder.Entity<RequestDetailsModel>()
                .HasOne(s => s.Requests)
                .WithMany(s => s.Books);

        }

        public DbSet<BooksModel> Books { get; set; }
        public DbSet<RequestModel> Requests { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<RequestDetailsModel> RequestDetails { get; set; }
        public DbSet<UsersModel> Users { get; set; }

    }
}