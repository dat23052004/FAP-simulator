using FapSimulator.Api.Data;
using FapSimulator.Api.Services;

namespace FapSimulator.Tests;

public sealed class MockDataTests
{
    [Fact]
    [Trait("Type", "Boundary")]
    public void MockData_WhenLoaded_ContainsExactly150ValidStudentRecords()
    {
        Assert.Equal(150, MockStudentData.Students.Count);
        Assert.Equal(
            150,
            MockStudentData.Students
                .Select(student => student.RollNumber)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Count());
        Assert.Equal(150, MockAcademicData.SemestersByRollNumber.Count);

        foreach (var student in MockStudentData.Students)
        {
            var semesters = MockAcademicData.SemestersByRollNumber[student.RollNumber];
            Assert.InRange(semesters.Count, 2, 3);
            Assert.All(semesters, semester =>
            {
                Assert.InRange(semester.Grades.Count, 3, 4);
                Assert.All(semester.Grades, grade =>
                {
                    Assert.InRange(grade.FinalScore10, 0m, 10m);
                    Assert.True(grade.Credits > 0);
                });
            });
        }

        var example = new StudentLookupService().GetAcademicRecord("SE180001");
        Assert.NotNull(example);
        Assert.Equal(3.51m, example.AcademicSummary.CurrentGpa);
        Assert.Equal(34, example.AcademicSummary.AttemptedCredits);
        Assert.Equal(34, example.AcademicSummary.EarnedCredits);
    }
}
