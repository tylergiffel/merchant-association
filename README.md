# Merchant Association API

A C# API project for managing merchant associations, businesses, and owners. Assume that this API has a corresponding UI project that is used by the board of a merchants association and also by business owners to update information that the merchants association can use to market the business, although the project does not have any authentication/authorization implemented yet.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop)
- [Docker Compose](https://docs.docker.com/compose/install/)

## Project Structure

```
MerchantAssociation/
├── MerchantAssociation.API/           # Main API project
│   ├── Controllers/                   # API controllers
│   ├── Data/                         # Database context and configurations
│   ├── Features/                     # CQRS features (Commands and Queries)
│   └── Models/                       # Domain models
└── docker-compose.yml                # Docker configuration for SQL Server
```

## Getting Started

1. Clone the repository:

```bash
git clone <repository-url>
cd merchant-association
```

2. Start the SQL Server container:

```bash
docker-compose up -d
```

This will start SQL Server with the following configuration:

- Server: localhost,1433
- Username: sa
- Password: YourStrong!Passw0rd
- Database: MerchantAssociation

3. Run the API project:

```bash
cd MerchantAssociation.API
dotnet run
```

The API will be available at:

- HTTPS: https://localhost:5001
- HTTP: http://localhost:5000

## API Endpoints

### Businesses

#### Create a Business

```http
POST /api/businesses
Content-Type: application/json

{
    "name": "Sample Business",
    "description": "A sample business description",
    "address": "123 Main St",
    "phoneNumber": "555-0123",
    "email": "contact@samplebusiness.com"
}
```

## Development

The project uses:

- Entity Framework Core for database operations
- MediatR for implementing the CQRS pattern
- SQL Server as the database
- Docker for containerization

## Database Schema

The database includes the following entities:

## Troubleshooting

1. If you can't connect to the database:

   - Ensure the SQL Server container is running: `docker ps`
   - Check the connection string in `appsettings.json`
   - Verify the SQL Server port (1433) is not in use

2. If the API fails to start:
   - Ensure .NET 8.0 SDK is installed
   - Check if the database container is running
   - Verify all required NuGet packages are restored
