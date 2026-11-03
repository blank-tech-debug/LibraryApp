# Library Book Management System

**Course:** IT Elective 2 – C#  
**Activity:** Activity 2 – Library Book Management  
**Language:** C#  
**Compiler:** Visual Studio Code

## Project Description

This project is a Library Book Management System developed using C# and Object-Oriented Programming (OOP).

The program demonstrates the use of classes, objects, constructors, encapsulation, inheritance, and polymorphism.

### Features

- Create Book objects with title, author, and ISBN.
- Check book availability.
- Borrow and return books.
- Display book information.
- Create an EBook class that inherits from Book.
- Demonstrate method overriding and polymorphism.

## Classes

### Book

The Book class contains the following properties:

- Title
- Author
- Isbn
- IsAvailable

It includes the following methods:

- `DisplayInfo()`
- `Borrow()`
- `Return()`

### EBook

The EBook class inherits from Book and includes an additional property:

- `FileSizeMb`

It overrides the `DisplayInfo()` method to display the file size.

## How to Run

1. Install the .NET SDK.
2. Open the project in Visual Studio Code.
3. Open the terminal.
4. Navigate to the LibraryApp project folder.
5. Run the following command:

```bash
dotnet run
```

## Output

The program displays the information of two books and one eBook.

It also demonstrates borrowing a book, attempting to borrow it again, returning the book, and polymorphism.

### Sample Output

```text
===== BOOK 1 =====
Title: The Great Gatsby
Author: F. Scott Fitzgerald
ISBN: 978-0743273565
Available: True

===== BOOK 2 =====
Title: To Kill a Mockingbird
Author: Harper Lee
ISBN: 978-0061120084
Available: True

===== EBOOK =====
Title: Clean Code
Author: Robert C. Martin
ISBN: 978-0132350884
Available: True
File Size: 5.5 MB

===== BORROW BOOK =====
The Great Gatsby has been borrowed.
The Great Gatsby is already borrowed.

===== RETURN BOOK =====
The Great Gatsby has been returned.
Title: The Great Gatsby
Author: F. Scott Fitzgerald
ISBN: 978-0743273565
Available: True

===== POLYMORPHISM =====
Title: Clean Code
Author: Robert C. Martin
ISBN: 978-0132350884
Available: True
File Size: 5.5 MB

Program completed.
```

## Concepts Demonstrated

- Object-Oriented Programming
- Classes and Objects
- Constructors
- Encapsulation
- Inheritance
- Method Overriding
- Polymorphism

## Author

Student Project – Library Book Management System
