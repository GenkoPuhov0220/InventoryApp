InventoryApp

InventoryApp е ASP.NET Core MVC уеб приложение за управление на складов инвентар.  
Приложението позволява добавяне, редакция, изтриване, търсене и генериране на отчет за наличните артикули в склада.

Основни функционалности
-Добавяне на нови артикули
-Редактиране на съществуващи артикули
-Изтриване на артикули
-Търсене и филтриране
-Генериране на отчет
-Seed данни при първо стартиране
-Unit тестове за бизнес логиката

Използвани технологии
-C#
-ASP.NET Core MVC
-Entity Framework Core (Code First)
-SQL Server
-LINQ
-Razor Views
-Dependency Injection
-xUnit (Unit Testing)

 Архитектура на проекта
-InventoryApp.Web → MVC UI (Controllers & Views)
-InventoryApp.Web.ViewModel → ViewModels
-InventoryApp.Services.Data → Бизнес логика
-InventoryApp.Data → DbContext
-InventoryApp.Data.Models → Database Entities
-InventoryApp.Services.Tests → Unit Tests

Как да стартирате приложението

1️.Клониране на проекта
 
 - git clone https://github.com/GenkoPuhov0220/InventoryApp.git

2.Отваряне на solution

- Отворете InventoryApp.sln in Visual Studio.
  
3. Конфигурация на база данни
   
 Connection string се намира в:
- InventoryApp.Web/appsettings.json/appsettings.Development.json
Предоставям примерен Connection string
- SqlServer - "Server =.;Database=InventoryApp;Integrated Security = True; TrustServerCertificate=True"
  
5. Прилагане на миграции
- Отворетр Package Manager Console
- Вътре в конзолата изписвате командата - Update-Database

5. Стартиране
- Натискате F5 или Run.

Автор:
Genko Puhov
Junior C# / .NET Developer






