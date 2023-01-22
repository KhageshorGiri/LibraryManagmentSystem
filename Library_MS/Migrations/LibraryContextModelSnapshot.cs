﻿// <auto-generated />
using System;
using Library_MS.Model_DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library_MS.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library_MS.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.HasKey("AddressID");

                    b.HasIndex("MemberID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Library_MS.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library_MS.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublishDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberOfPage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library_MS.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookAuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.HasKey("BookAuthorID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("Library_MS.Models.BookCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("bookCategories");
                });

            modelBuilder.Entity("Library_MS.Models.ExceptionLog", b =>
                {
                    b.Property<int>("ExceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("ExceptionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExceptionId");

                    b.ToTable("ExceptionLogs");
                });

            modelBuilder.Entity("Library_MS.Models.Fine", b =>
                {
                    b.Property<int>("FineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("FineAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FineDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IssueID")
                        .HasColumnType("int");

                    b.HasKey("FineID");

                    b.HasIndex("IssueID");

                    b.ToTable("Fines");
                });

            modelBuilder.Entity("Library_MS.Models.FineDetails", b =>
                {
                    b.Property<int>("FineDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<decimal?>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PayedDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FineDetailsID");

                    b.HasIndex("MemberID");

                    b.ToTable("FineDetails");
                });

            modelBuilder.Entity("Library_MS.Models.Issue", b =>
                {
                    b.Property<int>("IssueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<bool>("ReturnStaus")
                        .HasColumnType("bit");

                    b.Property<string>("dueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("issueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("returnDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IssueID");

                    b.HasIndex("BookID");

                    b.HasIndex("MemberID");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("Library_MS.Models.Librarian", b =>
                {
                    b.Property<int>("LibrarianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibrarianId");

                    b.ToTable("Librarians");
                });

            modelBuilder.Entity("Library_MS.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MembershipDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Library_MS.Models.Reserve", b =>
                {
                    b.Property<int>("ReserveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReserveDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReserveID");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("Library_MS.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LibrarianID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("LibrarianID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Library_MS.Models.Address", b =>
                {
                    b.HasOne("Library_MS.Models.Member", "Member")
                        .WithMany("Addresses")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Library_MS.Models.Book", b =>
                {
                    b.HasOne("Library_MS.Models.BookCategory", "BookCategory")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId");

                    b.Navigation("BookCategory");
                });

            modelBuilder.Entity("Library_MS.Models.BookAuthor", b =>
                {
                    b.HasOne("Library_MS.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorID");

                    b.HasOne("Library_MS.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Library_MS.Models.Fine", b =>
                {
                    b.HasOne("Library_MS.Models.Issue", "Issue")
                        .WithMany("Fines")
                        .HasForeignKey("IssueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("Library_MS.Models.FineDetails", b =>
                {
                    b.HasOne("Library_MS.Models.Member", "Member")
                        .WithMany("FineDetails")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Library_MS.Models.Issue", b =>
                {
                    b.HasOne("Library_MS.Models.Book", "Book")
                        .WithMany("Issues")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_MS.Models.Member", "Member")
                        .WithMany("Issues")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Library_MS.Models.Reserve", b =>
                {
                    b.HasOne("Library_MS.Models.Book", "Book")
                        .WithMany("Reserves")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_MS.Models.Member", "Member")
                        .WithMany("Reserves")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Library_MS.Models.User", b =>
                {
                    b.HasOne("Library_MS.Models.Librarian", "Librarian")
                        .WithMany("Users")
                        .HasForeignKey("LibrarianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Librarian");
                });

            modelBuilder.Entity("Library_MS.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Library_MS.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("Issues");

                    b.Navigation("Reserves");
                });

            modelBuilder.Entity("Library_MS.Models.BookCategory", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library_MS.Models.Issue", b =>
                {
                    b.Navigation("Fines");
                });

            modelBuilder.Entity("Library_MS.Models.Librarian", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Library_MS.Models.Member", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("FineDetails");

                    b.Navigation("Issues");

                    b.Navigation("Reserves");
                });
#pragma warning restore 612, 618
        }
    }
}
