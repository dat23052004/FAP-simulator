namespace FapSimulator.Api.Models;

public sealed record StudentProfileDto(
    string RollNumber,
    string FullName,
    string StudentEmail,
    string Major,
    string Campus,
    string Status,
    string CurrentSemester);

public sealed record StudentAcademicRecordDto(
    string RollNumber,
    AcademicSummaryDto AcademicSummary,
    IReadOnlyList<SemesterDto> Semesters,
    IReadOnlyList<RewardDto> Rewards,
    IReadOnlyList<DisciplineDto> Disciplines);

public sealed record AcademicSummaryDto(
    decimal CurrentGpa,
    decimal CumulativeAverage10,
    int AttemptedCredits,
    int EarnedCredits,
    int CompletedSemesters);

public sealed record SemesterDto(
    string SemesterCode,
    string SemesterName,
    string Status,
    int SemesterCredits,
    decimal AverageScore10,
    decimal SemesterGpa,
    IReadOnlyList<GradeDto> Grades);

public sealed record GradeDto(
    string SubjectCode,
    string SubjectName,
    int Credits,
    decimal FinalScore10,
    decimal GradePoint4,
    string Result);

public sealed record RewardDto(
    string Id,
    string Title,
    string Category,
    string SemesterCode,
    DateOnly IssuedDate,
    string Description);

public sealed record DisciplineDto(
    string Id,
    string Title,
    string Level,
    string SemesterCode,
    DateOnly IssuedDate,
    string Status,
    string Description);
