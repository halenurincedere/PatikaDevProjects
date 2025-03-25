# 📘 Code First Relation – Entity Framework Core

This is a simple example of using **Entity Framework Core with Code First approach** to create a relational database.

## 🧱 Database Design

This project creates a relational database with two tables: `Users` and `Posts`.

---

## 📄 Tables

### 1. Users

| Column   | Type   | Description                  |
|----------|--------|------------------------------|
| Id       | int    | Primary key, auto-increment  |
| Username | string | User's username              |
| Email    | string | User's email address         |

### 2. Posts

| Column   | Type   | Description                          |
|----------|--------|--------------------------------------|
| Id       | int    | Primary key, auto-increment          |
| Title    | string | Title of the post                    |
| Content  | string | Content of the post                  |
| UserId   | int    | Foreign key – refers to a User       |

---

## 🔗 Relationships

- One **User** can have **many Posts**.
- Each **Post** belongs to **one User**.

---

## 🧠 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Code First Migrations
