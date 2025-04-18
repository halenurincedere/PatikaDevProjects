# CodeFirstAPI Project

This is a simple ASP.NET Core Web API project that demonstrates **Code First** approach using **Entity Framework Core**.

## 🎯 Purpose

The main goal of this project is to create a database using Code First approach. It includes two basic tables:

### 🎬 Movie Table
- `Id` (int) – Primary key, auto-incremented
- `Title` (string) – Movie title
- `Genre` (string) – Movie genre (e.g., Action, Comedy)
- `ReleaseYear` (int) – Year of release

### 🎮 Game Table
- `Id` (int) – Primary key, auto-incremented
- `Name` (string) – Game name
- `Platform` (string) – Platform (e.g., PC, PlayStation)
- `Rating` (decimal) – Game rating (0-10)

## 🛠 Technologies Used

- ASP.NET Core 9
- Entity Framework Core
- SQL Server (Code First)
- C#

## 📂 Project Structure

```bash
CodeFirstAPI/ ├── Data/ │ ├── CodeFirstDbContext.cs │ └── Entities/ │ ├── Movie.cs │ └── Game.cs ├── Migrations/ └── Program.cs
```