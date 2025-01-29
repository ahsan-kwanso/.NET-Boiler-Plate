# MyAspNetApp

A .NET Core Web Application with user authentication features.

## Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- Visual Studio Code or Visual Studio 2022

## Database Setup

1. Install PostgreSQL and create a new database:

2. Update connection string in `appsettings.json` if needed:

json
"ConnectionStrings": {
"DefaultConnection": "Host=localhost;Database=testdb;Username=postgres;Password=password"
}

## Project Setup

1. Clone the repository

```
git clone [repository-url]
cd MyAspNetApp
```

2. Install required packages

```
dotnet restore
```

3. Apply database migrations and seed initial user

```
dotnet ef database update
```

This will:
- Create all necessary tables
- Seed the initial admin user
  - Email: admin@example.com
  - Password: admin123

## Running the Application

1. Start the application

```
dotnet run
```

Test the application using postman or any other API testing tool.