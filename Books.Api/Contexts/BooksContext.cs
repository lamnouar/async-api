using Books.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Api.Contexts
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}