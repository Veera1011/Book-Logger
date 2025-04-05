# 📚 BookLogger

BookLogger is a simple ASP.NET Core MVC web application that allows users to log and manage books they've read, including details like author, genre, status, and personal notes.

## 🔧 Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Bootstrap (for UI)
- Razor Pages

## 📁 Project Structure

BookLogger/ 
     ├── Controllers/ 
         │└── BooksController.cs 
     ├── Models/ 
         │ └── Book.cs 
         │ └── ApplicationDbContext.cs 
     ├── Views/ 
         │ └── Books/
             ├── Index.cshtml 
             ├── Create.cshtml 
             ├── Edit.cshtml 
             ├── Details.cshtml 
             └── Delete.cshtml 
     ├── wwwroot/ 
         │ └── (CSS/JS/Static Files) 
         ├── Program.cs
         ├── appsettings.json



## 🚀 Getting Started

### 1. Clone the Repository
git clone https://github.com/your-username/BookLogger.git
cd BookLogger
2. Restore Dependencies
dotnet restore
3. Build the Project
dotnet build
4. Add Required EF Core Packages (if not already added)
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
5. Apply Migrations
dotnet ef migrations add InitialCreate
dotnet ef database update
6. Run the Application
dotnet run
Navigate to http://localhost:5253 to use the app.

✨ Features
Add a new book with details like title, author, genre, status, and notes.

View all logged books.

Edit or delete books.

Data is stored in a local SQLite database.

🗃️ Database
This project uses Entity Framework Core with SQLite. The database file booklogger.db is created in the root directory.
