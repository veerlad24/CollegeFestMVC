# CollegeFestMVC — Version 2

A second implementation of the AMTICS College Technical Fest Registration System assignment.

## Requirements
- .NET 8 SDK
- VS Code (or any terminal)
- Internet access for Bootstrap and client-side validation CDN resources

## Run from the terminal
Open this folder in a terminal and run:

```bash
dotnet restore
dotnet run
```

Browse to:
- HTTP: http://localhost:5000
- HTTPS: https://localhost:5001

If HTTPS reports a development certificate issue, run `dotnet dev-certs https --trust` and try again.

## Run in VS Code
1. Open this folder.
2. Open Terminal → New Terminal.
3. Run `dotnet restore`, then `dotnet run`.
4. Use the URLs printed in the terminal.

## Features
- `Participant` and `Event` model classes, including nullable properties.
- Bootstrap registration form with Tag Helpers and validation.
- `FestController`: `Index`, `Register` GET/POST, `Details`, and `Welcome`.
- In-memory participant list; registrations reset when the application restarts.
- Bootstrap participant table and conditional success/pending alerts.
- `ParticipantExtensions.GetRegistrationStatus()` and `GetFeeCategory()`.
- `GlobalUsings.cs` global namespace declarations.
- Welcome, register, index and details navigation.

## GitHub submission
Create an empty repository on GitHub, then run the following from this folder (replace the URL with your own repository URL):

```bash
git init
git add .
git commit -m "Add College Fest MVC registration system"
git branch -M main
git remote add origin https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
git push -u origin main
```

Do not submit the example URL above. Submit the real URL of your repository.

## Fee categories used
- ₹0: Free Event
- ₹1–₹500: Standard Event
- Above ₹500: Premium Event

This is an educational assignment implementation; it does not use a database.
