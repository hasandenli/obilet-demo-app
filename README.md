# Obilet Demo Application

This is a demo application that consists of a Web API and a Web application, containerized using Docker.

## Project Structure

The solution contains two main projects:

1. **ObiletDemo.API** - A .NET 8 Web API project
   - Port: 80
   - Swagger UI available at root URL
   - Contains system information endpoints

2. **ObiletDemo.Web** - A .NET 8 Web Application
   - Port: 80
   - Default landing page: System/Info
   - MVC architecture

## Prerequisites

- Docker Desktop
- .NET 8 SDK (for local development)
- Git

## Getting Started

### Using Docker (Recommended)

1. Clone the repository:
   ```bash
   git clone [repository-url]
   cd obilet-demo-app
   ```

2. Build and run the containers:
   ```bash
   docker-compose up --build
   ```

3. Access the applications:
   - Web API: http://localhost:80
   - Web Application: http://localhost:80

### Local Development

1. Clone the repository:
   ```bash
   git clone [repository-url]
   cd obilet-demo-app
   ```

2. Run the API project:
   ```bash
   cd ObiletDemo.API
   dotnet run
   ```

3. Run the Web project:
   ```bash
   cd ObiletDemo.Web
   dotnet run
   ```

## API Endpoints

- `GET /api/system/info` - Get system information
- `GET /api/system/health` - Check system health
- `GET /api/system/version` - Get system version

## Web Application Routes

- `/System/Info` - System information page
- `/System/Health` - System health check page
- `/System/Version` - System version page

## Docker Configuration

The application uses the following Docker configuration:

- **API Container**:
  - Base image: mcr.microsoft.com/dotnet/aspnet:8.0
  - Build context: ObiletDemo.API
  - Port: 80

- **Web Container**:
  - Base image: mcr.microsoft.com/dotnet/aspnet:8.0
  - Build context: ObiletDemo.Web
  - Port: 80

## Development Notes

- The application uses .NET 8
- Both projects are configured to use port 80
- Swagger is enabled in development mode for the API
- The Web application uses MVC architecture
- Docker Compose is used for container orchestration

## Troubleshooting

If you encounter any issues:

1. Ensure Docker Desktop is running
2. Check if ports 80 are available
3. Verify .NET 8 SDK is installed for local development
4. Check Docker logs for any container-specific issues

## License

[Add your license information here] 