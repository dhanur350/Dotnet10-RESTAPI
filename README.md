# Backend Documentation

## Overview

This repository contains a small .NET 10 REST API backend used for demonstrations and development. The backend exposes HTTP endpoints implemented in `Controllers/RestController.cs` and includes small helper utilities in `Helpers/ArrayHelper.cs`.

## Tech Stack

- .NET 10 (Target framework: `net10.0`)
- C#

## Repository Structure

- `Program.cs` — application entrypoint and minimal host setup
- `appsettings.json` / `appsettings.Development.json` — configuration
- `Controllers/` — API controllers (main HTTP routes)
- `Helpers/` — utility classes used by controllers

## Requirements

- .NET 10 SDK installed

Verify with:

```bash
dotnet --version
```

## Run Locally

From the repository root run:

```bash
dotnet run --project RESTAPI
```

Or build and run the compiled binary:

```bash
dotnet build RESTAPI
dotnet bin/Debug/net10.0/RESTAPI
```

The API listens on the configured port (see `Properties/launchSettings.json` and `appsettings.json`). Use `appsettings.Development.json` for local overrides.

## Configuration

- `appsettings.json` contains configuration values. Use environment-specific files for overrides.
- Secrets or sensitive settings should be supplied via environment variables in production.

## API Endpoints

See `Controllers/RestController.cs` for concrete routes and request/response shapes. Example requests (adjust host/port):

```bash
curl http://localhost:5000/api/your-route
```

Replace `your-route` with the actual route names from the controller.

## Development Notes

- Controllers are implemented in `Controllers/` — add new routes by creating controller classes.
- Keep helper logic in `Helpers/` for reuse and unit testing.

## Testing

This repository currently does not include an automated test suite. Add unit tests using the `dotnet new xunit` template and a test project that references the `RESTAPI` project.

## Troubleshooting

- If the app fails to start, check console logs for binding errors and verify the port is available.
- Ensure the correct .NET SDK is on PATH.

## Contributing

Open a PR with a clear description of your changes. Follow existing code style and naming conventions.

## License

Project license is determined by the repository owner. Add a `LICENSE` file if you want an explicit license.
