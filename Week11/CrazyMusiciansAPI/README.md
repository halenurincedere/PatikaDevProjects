# Patika Crazy Musicians API

## Overview
Patika Crazy Musicians API is a RESTful service designed to manage musician-related data efficiently. It enables users to perform CRUD operations and search musicians using ASP.NET Core.

## Features
- CRUD Operations – Create, Read, Update, and Delete musicians.
- Search Functionality – Filter musicians by name.
- Data Validation – Ensures required fields are properly populated.
- Swagger Integration – Provides interactive API documentation.
- RESTful Architecture – Designed for scalability and easy integration.

## Technologies Used
- ASP.NET Core Web API (.NET 9)
- C#
- Swagger (API Documentation)

## API Endpoints
### Retrieve Musicians
- **GET /api/musicians** → Get all musicians.
- **GET /api/musicians/{id}** → Get musician by ID.
- **GET /api/musicians/search?fullName={name}** → Search musicians by name.

### Create & Update
- **POST /api/musicians** → Add a new musician.
- **PUT /api/musicians/{id}** → Update all details.
- **PATCH /api/musicians/{id}** → Update only the musician's name.

### Delete
- **DELETE /api/musicians/{id}** → Remove musician permanently.

## Installation & Execution
```sh
# Clone the repository
git clone https://github.com/halenurincedere/CrazyMusiciansAPI.git

# Navigate to the project
d cd CrazyMusiciansAPI

# Run the application
dotnet run
```

## Contributing
Feel free to submit a Pull Request or create an Issue for contributions.

## License
This project is licensed under the MIT License.

## Contact
For inquiries or suggestions, reach out via GitHub.