EStore Admin Module
A personal learning project built to gain hands-on, practical experience with core ASP.NET Core backend concepts — dependency injection, a layered service architecture, and Entity Framework Core — using a Brand management module as the working example.
Architecture
```
Browser
   │
   ▼
ASP.NET Core Middleware (Static Files, Routing)
   │
   ▼
BrandController  ──depends on──►  IBrandService
   │                                    │
   │                                    ▼
   │                              BrandService (business logic)
   │                                    │
   │                                    ▼
   └──renders──►  Razor View      BrandRepository (EF Core DbContext)
                                         │
                                         ▼
                                     SQL Server
```
Project Structure
Project	Responsibility
`EStoreAdminModule`	ASP.NET Core MVC entry point — `Program.cs` (middleware, DI registration), `BrandController`, Razor views
`EStoreAdminModel`	Domain models (`BrandModel`) and service interfaces (`IBrandService`)
`EStoreAdminService`	Service layer — business logic implementation (`BrandService`)
`EStoreAdminRepository`	Data access — EF Core `DbContext` (`BrandRepository`)
Features implemented
CRUD workflows for a Brand entity: list, create, and delete
Constructor-based Dependency Injection — `IBrandService → BrandService` and the EF Core `DbContext` are both injected rather than instantiated directly, keeping the controller decoupled and testable
Service lifetime management — registered as Transient in `Program.cs`, with Scoped and Singleton also explored during development to understand instance-reuse behavior
EF Core Code-First modeling — `DbSet<BrandModel>`, connection string managed via `appsettings.json`, schema generated and evolved through migrations
Razor views with Bootstrap styling and ASP.NET Core Tag Helpers (`asp-controller`, `asp-action`, `asp-route-id`) for dynamic, type-safe navigation
Attribute-based routing with route constraints (e.g., `{Id:guid}`)
Tech Stack
ASP.NET Core MVC · C# · Entity Framework Core · SQL Server · Razor Views · Bootstrap
Roadmap
This project is being actively extended toward:
Web API endpoints (early exploration visible in `BrandController` — a commented-out JSON-returning action and CORS setup for an Angular front-end)
Swagger / OpenAPI documentation
Docker containerization
Clean Architecture and CQRS patterns
A microservices-oriented structure further out
Getting Started
Clone the repository
Update the `EStoreConnection` string in `appsettings.json` to point to your local SQL Server instance
Run EF Core migrations: `Update-Database`
Run the `EStoreAdminModule` project
Why this project exists
Built alongside full-time work as a Senior C#/.NET Software Engineer in healthcare/medical-device software (WPF/desktop-focused), to build practical, product-company-grade experience with modern ASP.NET Core backend development.
