# BooksController Documentation

## Overview
The `BooksController` class in the BookApi project provides RESTful endpoints for managing books in the library. It supports standard CRUD operations and interacts with the data layer via the `IBookRepository` interface.

Base Route: `/api/books`

---

## Endpoints

### 1. Get All Books
- **Route:** `GET /api/books`
- **Description:** Retrieves a list of all books in the library.
- **Request:** No parameters required.
- **Response:**
  - `200 OK`: Returns an array of `Book` objects.

#### Example Response
```json
[
  {
    "id": 1,
    "title": "Book Title",
    "author": "Author Name",
    "publishedYear": 2020
  },
  ...
]
```

---

### 2. Get Book by ID
- **Route:** `GET /api/books/{id}`
- **Description:** Retrieves a single book by its unique ID.
- **Request:**
  - `id` (int, required): The ID of the book.
- **Response:**
  - `200 OK`: Returns the `Book` object.
  - `404 Not Found`: If the book does not exist.

#### Example Response
```json
{
  "id": 1,
  "title": "Book Title",
  "author": "Author Name",
  "publishedYear": 2020
}
```

---

### 3. Create a New Book
- **Route:** `POST /api/books`
- **Description:** Adds a new book to the library.
- **Request Body:** JSON object representing the book (without `id`).

#### Example Request
```json
{
  "title": "New Book",
  "author": "New Author",
  "publishedYear": 2023
}
```
- **Response:**
  - `201 Created`: Returns the created `Book` object with its assigned `id`.

#### Example Response
```json
{
  "id": 2,
  "title": "New Book",
  "author": "New Author",
  "publishedYear": 2023
}
```

---

### 4. Update an Existing Book
- **Route:** `PUT /api/books/{id}`
- **Description:** Updates the details of an existing book.
- **Request:**
  - `id` (int, required): The ID of the book to update (provided in the URL).
  - **Request Body:** JSON object representing the updated book (excluding `id`).

#### Example Request
```json
{
  "title": "Updated Book",
  "author": "Updated Author",
  "publishedYear": 2024
}
```
- **Response:**
  - `204 No Content`: If update is successful.
  - `400 Bad Request`: If the `id` in the URL does not match the `id` in the body.

---

### 5. Delete a Book
- **Route:** `DELETE /api/books/{id}`
- **Description:** Deletes a book by its ID.
- **Request:**
  - `id` (int, required): The ID of the book to delete.
- **Response:**
  - `204 No Content`: If deletion is successful.
  - `404 Not Found`: If the book does not exist.

---

## Error Handling
- `400 Bad Request`: Returned when the request is invalid (e.g., mismatched IDs).
- `404 Not Found`: Returned when a book with the specified ID does not exist.

## Usage Notes
- All endpoints return and accept data in JSON format.
- Use appropriate HTTP methods for each operation (GET, POST, PUT, DELETE).
- The controller uses dependency injection to access the repository layer.

---
For more details, refer to the source code in `BooksController.cs`.
