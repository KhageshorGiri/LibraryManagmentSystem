using Library_MS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Model_DBContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> bookCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<FineDetails> FineDetails { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(x => x.BookCategory)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.CategoryId);
           
            modelBuilder.Entity<Address>()
                .HasOne(x=>x.Member)
                .WithMany(b => b.Addresses)
                .HasForeignKey(bc => bc.MemberID);

            modelBuilder.Entity<BookAuthor>()
               .HasOne(x => x.Book)
               .WithMany(b => b.BookAuthors)
               .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookAuthor>()
               .HasOne(x => x.Author)
               .WithMany(b => b.BookAuthors)
               .HasForeignKey(bc => bc.AuthorID);

            modelBuilder.Entity<Issue>()
                .HasOne(x => x.Book)
                .WithMany(x => x.Issues)
                .HasForeignKey(x => x.BookID);

            modelBuilder.Entity<Issue>()
                .HasOne(x => x.Member)
                .WithMany(x => x.Issues)
                .HasForeignKey(x => x.MemberID);

            modelBuilder.Entity<Fine>()
                .HasOne(x => x.Issue)
                .WithMany(x => x.Fines)
                .HasForeignKey(x => x.IssueID);

                modelBuilder.Entity<FineDetails>()
                .HasOne(x => x.Member)
                .WithMany(x => x.FineDetails)
                .HasForeignKey(x => x.MemberID);

            modelBuilder.Entity<Reserve>()
                .HasOne(x => x.Member)
                .WithMany(x => x.Reserves)
                .HasForeignKey(x => x.MemberId);

            modelBuilder.Entity<Reserve>()
                .HasOne(x => x.Book)
                .WithMany(x => x.Reserves)
                .HasForeignKey(x => x.BookId);
        }
    }
}
