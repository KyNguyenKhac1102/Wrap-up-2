
using System;
using Microsoft.EntityFrameworkCore;
using WrapUp2.Models;
using System.Collections.Generic;

namespace WrapUp2.DataAccess{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Author>().HasMany(x => x.Books);
            modelBuilder.Entity<Book>().HasMany(x => x.Authors);
            modelBuilder.Entity<Client>().HasMany(x => x.Books);

            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorId = 1,
                FristName= "JK",
                LastName = "Rowling",
                DateOfBirth = new DateTime(1965, 07, 31),
                
            });

            modelBuilder.Entity<Client>().HasData(new Client
            {
                ClientId = 1,
                ClientName = "Peter",
                Address = "321 Scott",
                Email = "xxxPeterxxx@gmail.com",
                
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                BookName = "Harry Potter and the cup",
                Genre = "Fantasy",
                Country = "England",
                Series = "Harry Potter",
                BorrowPrice = 312,
                ClientId = 1,
                
            });
        }

    }
}