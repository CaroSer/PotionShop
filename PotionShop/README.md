
# Potion Shop CRUD Application

This repository contains a Potion Shop CRUD application developed using C# and Blazor. The application allows users to manage a list of potions with full Create, Read, Update, and Delete (CRUD) functionality.

## Features

- **Potion Management**: Add, view, edit, and delete potions.
- **Blazor UI**: Interactive and responsive user interface built with Blazor.
- **Entity Framework Core**: Used for database operations.
- **ASP.NET Core**: Backend server to handle API requests.
- **Validation**: Input validation to ensure data integrity.

## Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- SQL Server or SQLite for the database

### Installation

1. Clone the repository:
```
   git clone git@github.com:CaroSer/PotionShop.git
```
   
2. Navigate to the project directory:
```
   cd potion-shop-crud
```

3. Restore the dependencies:
```
   dotnet restore
```
   
4. Update the database connection string in `appsettings.json`.

### Running the Application

1. Apply database migrations:
   ```
   dotnet ef database update
   ```
2. Run the application:
   ```
   dotnet run
   ```
   
3. Open your browser and navigate to `https://localhost:5001`.

## Usage

- **Add Potion**: Click the "Add Potion" button and fill out the form to add a new potion.
- **View Potions**: The home page displays a list of all potions with options to edit or delete each potion.
- **Edit Potion**: Click the edit button next to a potion to modify its details.
- **Delete Potion**: Click the delete button next to a potion to remove it from the list.

---

Feel free to reach out if you have any questions or need further assistance!
