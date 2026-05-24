# 💸 SpendSmart - Personal Expense Tracker

SpendSmart is a personal expense tracking web application built using **ASP.NET Core MVC** and **Entity Framework Core**. It provides an intuitive, web-based dashboard to record daily expenses, track total spending, and edit or delete records to maintain financial control.

---

## 🚀 Core Features

- **Personalized Dashboard**: A clean and welcoming entry point that links directly to key operational modules.
- **Expense Log & Overview**: A dynamic data table listing all logged expenses with automatic total calculation.
- **Form-Validation Safety**: Server-side and client-side validation to ensure clean data input (requires value and description).
- **Full CRUD Management**:
  - **Create**: Add new expenses with precise decimal amount values and custom descriptions.
  - **Read**: Fetch and display all historical expenses in a readable layout.
  - **Update**: Pre-populate and edit existing expense descriptions and amounts.
  - **Delete**: Safely delete expenses with an interactive confirmation prompt.

---

## 🛠️ Tech Stack

- **Framework**: .NET 8 / ASP.NET Core MVC (Model-View-Controller)
- **Data Access**: Entity Framework Core
- **Database**: Microsoft SQL Server
- **Frontend UI**: CSHTML Razor Views, HTML5, CSS3, Bootstrap 5, Bootstrap Icons
- **Client Validation**: jQuery & jQuery Validation Unobtrusive

---

## 📂 Project Structure

```
Spend_Smart/
├── Controllers/
│   └── HomeController.cs           # Main logic for routing, database actions, and views
├── Migrations/                     # Entity Framework Core database migrations
├── Models/
│   ├── Expense.cs                  # Expense data model (Id, Value, Description)
│   └── SpendSmartDbContext.cs       # Entity Framework database context
├── Views/
│   ├── Home/
│   │   ├── CreateEditExpense.cshtml # Form for creating and editing expenses
│   │   ├── Expenses.cshtml          # Data table displaying logged expenses
│   │   └── Index.cshtml             # Welcome home dashboard
│   ├── Shared/                     # Layouts, navigation, and validation scripts
│   └── _ViewImports.cshtml
├── wwwroot/                        # Static assets (compiled CSS, JS, Bootstrap)
├── appsettings.json                # Database connection string configuration
├── Program.cs                      # Application setup and services configuration
└── SpendSmart.sln                  # Visual Studio solution file
```

---

## ⚙️ Setup & Installation

### Prerequisites
- **.NET SDK 8.0+**
- **MS SQL Server** (LocalDB or Express)

### Step 1: Clone and Configure Database
1. Open [appsettings.json](file:///c:/Users/Sarim/Desktop/Project%20Development/Spend_Smart/appsettings.json) and locate the connection string:
   ```json
   "ConnectionStrings": {
     "SpendSmartDbConnectionString": "Server=(localdb)\\mssqllocaldb;Database=SpendSmartDb;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
   *Modify the connection string if your SQL Server configuration differs.*

### Step 2: Apply Database Migrations
Run the following command in the project root to create the database schema:
```bash
dotnet ef database update
```
*(Alternatively, run `Update-Database` inside the Package Manager Console in Visual Studio).*

### Step 3: Run the Application
Start the development server:
```bash
dotnet run
```
Open your browser and navigate to `https://localhost:7146` or the URL printed in the console.

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](file:///c:/Users/Sarim/Desktop/Project%20Development/Spend_Smart/LICENSE) file for details.
