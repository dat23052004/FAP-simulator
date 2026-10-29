# FAP Simulator

FAP Simulator is a small .NET 9 API used by RLAMS for local/demo integration. It contains fictional, deterministic data only: 150 explicitly declared student profiles and fixed academic templates mapped to every roll number. It has no database and no write API.

## API

Both business endpoints require `X-Api-Key`:

- `GET /api/v1/students/{rollNumber}` returns personal profile fields only.
- `GET /api/v1/students/{rollNumber}/academic-record` returns completed semesters, final course scores, GPA/credits, rewards and disciplines.

Responses use `400` for an invalid roll-number format, `401` for a missing or invalid API key, and `404` for a well-formed roll number that is not in the demo data.

## Run locally

```powershell
$env:Fap__ApiKey = '<shared-development-key>'
dotnet run --project src/FapSimulator.Api --urls http://localhost:5002
```

Swagger is available at `http://localhost:5002/swagger` in Development. Never commit the shared API key; configure the same value in RLAMS through user secrets or environment variables.

Example:

```powershell
$headers = @{ 'X-Api-Key' = $env:Fap__ApiKey }
Invoke-RestMethod http://localhost:5002/api/v1/students/SE180001 -Headers $headers
Invoke-RestMethod http://localhost:5002/api/v1/students/SE180001/academic-record -Headers $headers
```

## Verify

```powershell
dotnet test FapSimulator.sln -c Release
```

The tests verify the 150-record invariant, academic data shape, the documented GPA example, endpoint separation, and API-key protection.
