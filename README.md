# Obilet Demo Application

This is a demo application that consists of a Web API and a Web application, containerized using Docker.

## Project Structure

The solution contains two main projects:

1. **ObiletDemo.API** - A .NET 8 Web API project
   - Port: 5007
   - Swagger UI available at root URL
   - Contains system information endpoints

2. **ObiletDemo.Web** - A .NET 8 Web Application
   - Port: 5006
   - Default landing page: Journey/Index
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
   - Web API: http://localhost:5007
   - Web Application: http://localhost:5006

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

- `/Journey/Index` - Journey search page
- `/System/Info` - System information page
- `/System/Health` - System health check page
- `/System/Version` - System version page

## Docker Configuration

The application uses the following Docker configuration:

- **API Container**:
  - Base image: mcr.microsoft.com/dotnet/aspnet:8.0
  - Build context: ObiletDemo.API
  - Port: 5007

- **Web Container**:
  - Base image: mcr.microsoft.com/dotnet/aspnet:8.0
  - Build context: ObiletDemo.Web
  - Port: 5006

## Development Notes

- The application uses .NET 8
- API project is configured to use port 5007
- Web project is configured to use port 5006
- Swagger is enabled in development mode for the API
- The Web application uses MVC architecture
- Docker Compose is used for container orchestration

## Troubleshooting

If you encounter any issues:
- Make sure ports 5006 and 5007 are not in use by other applications
- Check Docker logs for any container-related issues
- Verify that both containers are running using `docker ps`

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details. 