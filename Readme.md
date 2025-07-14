# BookApi

## Description
BookApi is a RESTful Web API built with ASP.NET Core for managing a library of books. It demonstrates clean architecture, separation of concerns, and the use of Entity Framework Core with a SQLite database. The API supports CRUD operations for books and follows best practices for maintainability and scalability.

## Project Structure
```
BookLibrary/
├── BookApi/
│   ├── Controllers/
│   │   └── BooksController.cs
│   ├── Data/
│   │   └── BookContext.cs
│   ├── Repositories/
│   │   ├── IBookRepository.cs
│   │   └── BookRepository.cs
│   ├── Program.cs
│   ├── appsettings.json
│   └── ...
└── ...
```

## Classes and Methods

### BookContext (Data/BookContext.cs)
- Inherits from `DbContext`
- Manages the database context for books
- Methods:
  - `DbSet<Book> Books` (property)

### IBookRepository (Repositories/IBookRepository.cs)
- Interface for book data access
- Methods:
  - `IEnumerable<Book> GetAll()`
  - `Book GetById(int id)`
  - `void Add(Book book)`
  - `void Update(Book book)`
  - `void Delete(int id)`

### BookRepository (Repositories/BookRepository.cs)
- Implements `IBookRepository`
- Methods:
  - Implements all methods from `IBookRepository`

### BooksController (Controllers/BooksController.cs)
- API controller for book endpoints
- Methods:
  - `Get()` - Get all books
  - `Get(int id)` - Get book by ID
  - `Post(Book book)` - Add a new book
  - `Put(int id, Book book)` - Update a book
  - `Delete(int id)` - Delete a book

## Patterns Used
- **Repository Pattern**: Abstracts data access logic and provides a clean interface for data operations.
- **Dependency Injection**: Services and repositories are injected via the constructor.
- **Separation of Concerns**: Controllers, data context, and repositories are separated for maintainability.

## Commands

### Build the Project
```
dotnet build
```

### Run the Project
```
dotnet run --project BookApi/BookApi.csproj
```

### Test the Project
*If you have tests (e.g., in a BookApi.Tests project):*
```
dotnet test
```

### Publish the Project
```
dotnet publish -c Release -o ./publish
```

---
For more details, see the source code in each folder.
