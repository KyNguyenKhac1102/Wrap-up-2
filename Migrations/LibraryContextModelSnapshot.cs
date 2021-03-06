// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WrapUp2.DataAccess;

namespace WrapUp2.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorId", "BooksBookId");

                    b.HasIndex("BooksBookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("WrapUp2.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FristName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            DateOfBirth = new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FristName = "JK",
                            LastName = "Rowling"
                        });
                });

            modelBuilder.Entity("WrapUp2.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("BorrowPrice")
                        .HasColumnType("real");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Series")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("ClientId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookName = "Harry Potter and the cup",
                            BorrowPrice = 312f,
                            ClientId = 1,
                            Country = "England",
                            Genre = "Fantasy",
                            Series = "Harry Potter"
                        });
                });

            modelBuilder.Entity("WrapUp2.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Address = "321 Scott",
                            ClientName = "Peter",
                            Email = "xxxPeterxxx@gmail.com"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("WrapUp2.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WrapUp2.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WrapUp2.Models.Book", b =>
                {
                    b.HasOne("WrapUp2.Models.Client", "Client")
                        .WithMany("Books")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("WrapUp2.Models.Client", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
