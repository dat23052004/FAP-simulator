using System.Net.Mail;
using FapSimulator.Api.Middleware;
using FapSimulator.Api.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<StudentLookupService>();

var app = builder.Build();

app.UseMiddleware<ApiKeyMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var students = app.MapGroup("/api/v1/students");

students.MapGet("/by-email/{email}", (string email, StudentLookupService service) =>
{
    if (!EmailAddressValidator.IsValid(email))
    {
        return Results.Problem(
            statusCode: StatusCodes.Status400BadRequest,
            title: "Invalid email.",
            detail: "A valid student email address is required.");
    }

    var profile = service.GetProfile(email);
    return profile is null
        ? Results.Problem(
            statusCode: StatusCodes.Status404NotFound,
            title: "Student not found.")
        : Results.Ok(profile);
})
.WithName("GetStudentProfile")
.WithSummary("Returns the demo student's personal profile.");

students.MapGet("/by-email/{email}/academic-record", (string email, StudentLookupService service) =>
{
    if (!EmailAddressValidator.IsValid(email))
    {
        return Results.Problem(
            statusCode: StatusCodes.Status400BadRequest,
            title: "Invalid email.",
            detail: "A valid student email address is required.");
    }

    var record = service.GetAcademicRecord(email);
    return record is null
        ? Results.Problem(
            statusCode: StatusCodes.Status404NotFound,
            title: "Student not found.")
        : Results.Ok(record);
})
.WithName("GetStudentAcademicRecord")
.WithSummary("Returns grades, GPA, rewards and disciplines for the demo student.");

app.Run();

public partial class Program;

internal static class EmailAddressValidator
{
    public static bool IsValid(string value) =>
        !string.IsNullOrWhiteSpace(value) &&
        value.Length <= 254 &&
        MailAddress.TryCreate(value, out var address) &&
        string.Equals(address.Address, value, StringComparison.OrdinalIgnoreCase);
}
