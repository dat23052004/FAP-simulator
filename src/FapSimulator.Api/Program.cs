using System.Text.RegularExpressions;
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

students.MapGet("/{rollNumber}", (string rollNumber, StudentLookupService service) =>
{
    if (!RollNumberValidator.IsValid(rollNumber))
    {
        return Results.Problem(
            statusCode: StatusCodes.Status400BadRequest,
            title: "Invalid roll number.",
            detail: "Roll number must use the format SE followed by six digits.");
    }

    var profile = service.GetProfile(rollNumber);
    return profile is null
        ? Results.Problem(
            statusCode: StatusCodes.Status404NotFound,
            title: "Student not found.")
        : Results.Ok(profile);
})
.WithName("GetStudentProfile")
.WithSummary("Returns the demo student's personal profile.");

students.MapGet("/{rollNumber}/academic-record", (string rollNumber, StudentLookupService service) =>
{
    if (!RollNumberValidator.IsValid(rollNumber))
    {
        return Results.Problem(
            statusCode: StatusCodes.Status400BadRequest,
            title: "Invalid roll number.",
            detail: "Roll number must use the format SE followed by six digits.");
    }

    var record = service.GetAcademicRecord(rollNumber);
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

internal static partial class RollNumberValidator
{
    public static bool IsValid(string value) => Pattern().IsMatch(value);

    [GeneratedRegex("^SE\\d{6}$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)]
    private static partial Regex Pattern();
}
