# JWT Authentication Practice

## 1. User Model

- Id (int, primary key)
- Email (string, unique)
- Password (string)

## 2. Database

- Entity Framework Core used
- User model added to DbContext

## 3. JWT Token

- AuthController created
- Login method checks Email and Password
- Returns JWT token if user is valid

## 4. JWT Validation

- JWT validation configured in Program.cs
- `[Authorize]` attribute used to protect endpoints