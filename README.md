InventoryApp

InventoryApp е ASP.NET Core MVC уеб приложение за управление на складов инвентар.  
Приложението позволява добавяне, редакция, изтриване, търсене и генериране на отчет за наличните артикули в склада.

Features

- Add new inventory items
- Edit existing items
- Delete items
- Search and filter items
- Inventory report (total items & total value)
- Seed data on first run
- Unit tests for services

Technologies

- C#
- ASP.NET Core MVC
- Entity Framework Core (Code First)
- SQL Server / LocalDB
- LINQ
- Razor Views
- Dependency Injection
- xUnit (Unit Testing)
- 
 Project Architecture

-InventoryApp.Web MVC UI -> Controllers & Views
-InventoryApp.Web.ViewModel -> ViewModels used by the UI 
-InventoryApp.Services.Data -> Business logic 
-InventoryApp.Data -> DbContext 
-InventoryApp.Data.Models -> Database entities
-InventoryApp.Services.Tests -> Unit tests 


Как да стартирате приложението

1️.Clone repository
 
 - git clone https://github.com/GenkoPuhov0220/InventoryApp.git

2.Open solution

- Отворете InventoryApp.sln in Visual Studio.

3. Apply database migrations
- Отворетр Package Manager Console
- Вътре в конзолата изписвате командата - Update-Database

4. Стартиране
- Натискате F5 или Run.

Изготвил:
Genko Puhov
Junior C# / .NET Developer






