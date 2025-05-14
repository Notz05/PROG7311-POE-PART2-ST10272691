# AgriEnergy Connect Platform   
**BCAD PROG7311 - Part 2 Submission**  
**Student Number:** ST10272691

---

##  Overview

AgriEnergy Connect is a web-based platform developed to bridge the gap between **Farmers** and **Employees** in the agricultural energy sector. The system enables farmers to manage their products efficiently, while employees can explore and filter products for operational purposes.

This solution was developed using **ASP.NET Core MVC** with **Entity Framework Core**, and follows modern development best practices to ensure scalability, usability, and responsiveness.

---

##  Features

-  **User Authentication**  
  Supports registration and login via Identity. Role-based access is configured for **Farmers** and **Employees**.

-  **Farmer Features**  
  - Add, edit, delete personal products  
  - Manage profile  
  - View own product listings

-  **Employee Features**  
  - View all farmers and their products  
  - Filter products by category  
  - Search across the platform

-  **Data Validation**  
  Client and server-side validations ensure data integrity.

-  **Safeguards**  
  Farmers with associated products cannot be deleted to preserve referential integrity.

-  **Improved UI**  
  Bootstrap cards and confirmation modals for a cleaner user experience.

-  **Seeded Demo Data**  
  The system includes default farmers and products to simulate real-world use.

---

##  Technologies Used

- ASP.NET Core MVC (.NET 6)  
- Entity Framework Core  
- SQL Server (LocalDB)  
- Bootstrap 5  
- Razor Pages  
- Identity for authentication

---

##  Testing (Optional/Planned)

While formal unit testing was not the focus of this prototype, the application has been manually tested with seeded data for functional correctness. If time permits, unit tests using xUnit and Moq are recommended in future iterations.

---

##  How to Run the Project

>  **Important:** This is a Visual Studio (.NET Core) web application.

### 1. **Clone the Repository**
git clone https://github.com/Notz05/PROG7311-POE-PART2-ST10272691.git
cd PROG7311-POE-PART2-ST10272691

## 2. Install Dependencies
Open the solution in Visual Studio and allow NuGet to restore missing packages.

## 3. Configure the Database
Option A: Use the Provided Seeded Data
The application includes seed data in Data/ApplicationDbInitializer.cs. This will automatically run at startup.

Option B: Use Your Own Database
If you'd prefer to connect to your own SQL Server, replace the connection string in:
appsettings.json
Example:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgriEnergyDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}

## 4. Apply Migrations
Update-Database

Or, from the Package Manager Console in Visual Studio:
Add-Migration Initial
Update-Database

## 5. Run the Application
Press F5 or click the Run button in Visual Studio.

References
Microsoft Docs. (2024). ASP.NET Core MVC

Entity Framework Core Docs. (2024). EF Core Overview

Bootstrap Documentation. (2024). Bootstrap 5

Stack Overflow. (2024). Various threads for ASP.NET Core issues

Code Maze. (2023). ASP.NET Core Identity Series

Visual Studio Documentation. (2024). Publishing Projects to GitHub 
