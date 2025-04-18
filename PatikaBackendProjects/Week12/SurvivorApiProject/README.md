# Survivor API Project

This is a Web API application built with ASP.NET Core that simulates a simplified version of a Survivor-style competition system. It supports managing **categories** and **competitors** with a **one-to-many relationship** (one category can have many competitors).

## 📌 Technologies Used

- ASP.NET Core 9
- Entity Framework Core
- PostgreSQL
- Swagger / OpenAPI
- C#

## 📂 Project Structure

- `Entities/` – Contains data models (BaseEntity, Category, Competitor)
- `Context/` – Contains the `SurvivorDbContext` for EF Core
- `Controllers/` – Web API controllers (Categories, Competitors)
- `Models/` – DTO classes for request and response structures

## 📑 Database Structure

### Category Table
- `Id` (int)
- `Name` (string)
- `CreatedDate` (DateTime)
- `ModifiedDate` (DateTime)

### Competitor Table
- `Id` (int)
- `FirstName` (string)
- `LastName` (string)
- `CategoryId` (int, foreign key)
- `CreatedDate` (DateTime)
- `ModifiedDate` (DateTime)

A **Category** can have multiple **Competitors**, and each **Competitor** belongs to one **Category**.

## 🔁 API Endpoints

### ✅ CompetitorController

| Method | Route                                   | Description                            |
|--------|-----------------------------------------|----------------------------------------|
| GET    | `/api/competitors`                      | Get all competitors                    |
| GET    | `/api/competitors/{id}`                 | Get a competitor by ID                 |
| GET    | `/api/competitors/categories/{id}`      | Get competitors by category ID         |
| POST   | `/api/competitors`                      | Create a new competitor                |
| PUT    | `/api/competitors/{id}`                 | Update a competitor                    |
| DELETE | `/api/competitors/{id}`                 | Soft-delete a competitor               |

---

### ✅ CategoryController

| Method | Route                            | Description                        |
|--------|----------------------------------|------------------------------------|
| GET    | `/api/categories`                | Get all categories                 |
| GET    | `/api/categories/{id}`           | Get a category by ID (with competitors) |
| POST   | `/api/categories`                | Create a new category              |
| PUT    | `/api/categories/{id}`           | Update a category                  |
| DELETE | `/api/categories/{id}`           | Soft-delete a category             |

---

## 🧪 Testing the API

You can test the API using:

- **Swagger UI**: Go to `https://localhost:{PORT}/swagger`
- **Postman** or any REST client

Make sure the PostgreSQL database is running and the connection string is correct in `appsettings.json`.