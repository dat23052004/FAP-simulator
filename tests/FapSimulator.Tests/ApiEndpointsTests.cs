using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace FapSimulator.Tests;

public sealed class ApiEndpointsTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> factory;

    public ApiEndpointsTests(WebApplicationFactory<Program> factory)
    {
        this.factory = factory.WithWebHostBuilder(builder =>
            builder.UseSetting("Fap:ApiKey", "integration-test-key"));
    }

    [Fact]
    public async Task GetEndpoints_WhenStudentExists_ReturnSeparatedProfileAndAcademicData()
    {
        using var client = factory.CreateClient();
        client.DefaultRequestHeaders.Add("X-Api-Key", "integration-test-key");

        using var profileResponse = await client.GetAsync("/api/v1/students/SE180001");
        Assert.Equal(HttpStatusCode.OK, profileResponse.StatusCode);
        using var profile = JsonDocument.Parse(await profileResponse.Content.ReadAsStringAsync());
        Assert.Equal("SE180001", profile.RootElement.GetProperty("rollNumber").GetString());
        Assert.False(profile.RootElement.TryGetProperty("academicSummary", out _));

        using var academicResponse = await client.GetAsync(
            "/api/v1/students/SE180001/academic-record");
        Assert.Equal(HttpStatusCode.OK, academicResponse.StatusCode);
        using var academic = JsonDocument.Parse(await academicResponse.Content.ReadAsStringAsync());
        Assert.Equal(3.51m, academic.RootElement
            .GetProperty("academicSummary")
            .GetProperty("currentGpa")
            .GetDecimal());
        Assert.Equal(3, academic.RootElement.GetProperty("semesters").GetArrayLength());
    }

    [Fact]
    public async Task GetProfile_WhenApiKeyIsMissing_ReturnsUnauthorized()
    {
        using var client = factory.CreateClient();

        using var response = await client.GetAsync("/api/v1/students/SE180001");

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }
}
