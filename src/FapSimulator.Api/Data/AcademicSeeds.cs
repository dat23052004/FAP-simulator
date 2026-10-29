namespace FapSimulator.Api.Data;

public sealed record GradeSeed(
    string SubjectCode,
    string SubjectName,
    int Credits,
    decimal FinalScore10);

public sealed record SemesterSeed(
    string SemesterCode,
    string SemesterName,
    IReadOnlyList<GradeSeed> Grades);
