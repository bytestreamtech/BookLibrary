using BookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        // Seed method to add initial books if database is empty
        public async Task SeedAsync()
        {
            if (!Books.Any())
            {
                var books = new List<Book>
                {
                    new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedYear = 1960, Language = "English", Genre = "Fiction" },
                    new Book { Title = "1984", Author = "George Orwell", PublishedYear = 1949, Language = "English", Genre = "Dystopian" },
                    new Book { Title = "Pride and Prejudice", Author = "Jane Austen", PublishedYear = 1813, Language = "English", Genre = "Romance" },
                    new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedYear = 1925, Language = "English", Genre = "Fiction" },
                    new Book { Title = "Moby-Dick", Author = "Herman Melville", PublishedYear = 1851, Language = "English", Genre = "Adventure" },
                    new Book { Title = "War and Peace", Author = "Leo Tolstoy", PublishedYear = 1869, Language = "Russian", Genre = "Historical" },
                    new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", PublishedYear = 1951, Language = "English", Genre = "Fiction" },
                    new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", PublishedYear = 1937, Language = "English", Genre = "Fantasy" },
                    new Book { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", PublishedYear = 1866, Language = "Russian", Genre = "Philosophical" },
                    new Book { Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky", PublishedYear = 1880, Language = "Russian", Genre = "Philosophical" },
                    new Book { Title = "Brave New World", Author = "Aldous Huxley", PublishedYear = 1932, Language = "English", Genre = "Dystopian" },
                    new Book { Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", PublishedYear = 1954, Language = "English", Genre = "Fantasy" },
                    new Book { Title = "Jane Eyre", Author = "Charlotte Brontë", PublishedYear = 1847, Language = "English", Genre = "Romance" },
                    new Book { Title = "Wuthering Heights", Author = "Emily Brontë", PublishedYear = 1847, Language = "English", Genre = "Romance" },
                    new Book { Title = "The Alchemist", Author = "Paulo Coelho", PublishedYear = 1988, Language = "Portuguese", Genre = "Adventure" },
                    new Book { Title = "The Odyssey", Author = "Homer", PublishedYear = -800, Language = "Greek", Genre = "Epic" },
                    new Book { Title = "Don Quixote", Author = "Miguel de Cervantes", PublishedYear = 1605, Language = "Spanish", Genre = "Adventure" },
                    new Book { Title = "The Divine Comedy", Author = "Dante Alighieri", PublishedYear = 1320, Language = "Italian", Genre = "Epic" },
                    new Book { Title = "Anna Karenina", Author = "Leo Tolstoy", PublishedYear = 1877, Language = "Russian", Genre = "Romance" },
                    new Book { Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", PublishedYear = 1967, Language = "Spanish", Genre = "Magic Realism" }
                };
                await Books.AddRangeAsync(books);
                await SaveChangesAsync();
            }
        }
    }
}