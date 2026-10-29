using FapSimulator.Api.Data;
using FapSimulator.Api.Models;

namespace FapSimulator.Api.Services;

public static class AcademicGradeCalculator
{
    public static StudentAcademicRecordDto BuildRecord(
        string rollNumber,
        IReadOnlyList<SemesterSeed> semesterSeeds,
        IReadOnlyList<RewardDto> rewards,
        IReadOnlyList<DisciplineDto> disciplines)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(rollNumber);
        ArgumentNullException.ThrowIfNull(semesterSeeds);

        var semesters = semesterSeeds.Select(BuildSemester).ToArray();
        var allGrades = semesters.SelectMany(semester => semester.Grades).ToArray();
        var attemptedCredits = allGrades.Sum(grade => grade.Credits);
        if (attemptedCredits == 0)
        {
            throw new InvalidOperationException("An academic record must contain graded credits.");
        }

        var earnedCredits = allGrades
            .Where(grade => grade.FinalScore10 >= 5m)
            .Sum(grade => grade.Credits);
        var cumulativeAverage10 = WeightedAverage(
            allGrades.Select(grade => (grade.FinalScore10, grade.Credits)));
        var currentGpa = WeightedAverage(
            allGrades.Select(grade => (grade.GradePoint4, grade.Credits)));

        return new StudentAcademicRecordDto(
            rollNumber,
            new AcademicSummaryDto(
                Round(currentGpa),
                Round(cumulativeAverage10),
                attemptedCredits,
                earnedCredits,
                semesters.Length),
            semesters,
            rewards,
            disciplines);
    }

    public static decimal ToGradePoint4(decimal finalScore10) => finalScore10 switch
    {
        < 0m or > 10m => throw new ArgumentOutOfRangeException(
            nameof(finalScore10),
            "Final score must be between 0 and 10."),
        >= 8.5m => 4m,
        >= 8m => 3.5m,
        >= 7m => 3m,
        >= 6.5m => 2.5m,
        >= 5.5m => 2m,
        >= 5m => 1.5m,
        _ => 0m,
    };

    private static SemesterDto BuildSemester(SemesterSeed seed)
    {
        if (seed.Grades.Count is < 3 or > 4)
        {
            throw new InvalidOperationException(
                $"Semester {seed.SemesterCode} must contain three or four grades.");
        }

        var grades = seed.Grades.Select(grade =>
        {
            if (grade.Credits <= 0)
            {
                throw new InvalidOperationException("Course credits must be positive.");
            }

            var gradePoint4 = ToGradePoint4(grade.FinalScore10);
            return new GradeDto(
                grade.SubjectCode,
                grade.SubjectName,
                grade.Credits,
                grade.FinalScore10,
                gradePoint4,
                grade.FinalScore10 >= 5m ? "Passed" : "Failed");
        }).ToArray();

        var semesterCredits = grades.Sum(grade => grade.Credits);
        return new SemesterDto(
            seed.SemesterCode,
            seed.SemesterName,
            "Completed",
            semesterCredits,
            Round(WeightedAverage(grades.Select(grade => (grade.FinalScore10, grade.Credits)))),
            Round(WeightedAverage(grades.Select(grade => (grade.GradePoint4, grade.Credits)))),
            grades);
    }

    private static decimal WeightedAverage(IEnumerable<(decimal Value, int Credits)> values)
    {
        var materialized = values.ToArray();
        var credits = materialized.Sum(value => value.Credits);
        return credits == 0
            ? 0m
            : materialized.Sum(value => value.Value * value.Credits) / credits;
    }

    private static decimal Round(decimal value) =>
        decimal.Round(value, 2, MidpointRounding.AwayFromZero);
}
