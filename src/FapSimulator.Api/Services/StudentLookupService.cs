using FapSimulator.Api.Data;
using FapSimulator.Api.Models;

namespace FapSimulator.Api.Services;

public sealed class StudentLookupService
{
    private readonly IReadOnlyDictionary<string, StudentProfileDto> profilesByEmail =
        MockStudentData.Students.ToDictionary(
            profile => profile.StudentEmail,
            StringComparer.OrdinalIgnoreCase);

    public StudentLookupService()
    {
        if (profilesByEmail.Count != 150 || MockAcademicData.SemestersByRollNumber.Count != 150)
        {
            throw new InvalidOperationException(
                "FAP Simulator must contain exactly 150 complete student records.");
        }
    }

    public StudentProfileDto? GetProfile(string email) =>
        profilesByEmail.GetValueOrDefault(email);

    public StudentAcademicRecordDto? GetAcademicRecord(string email)
    {
        if (!profilesByEmail.TryGetValue(email, out var profile) ||
            string.IsNullOrWhiteSpace(profile.RollNumber) ||
            !MockAcademicData.SemestersByRollNumber.TryGetValue(profile.RollNumber, out var semesters))
        {
            return null;
        }

        return AcademicGradeCalculator.BuildRecord(
            profile.RollNumber,
            semesters,
            MockAchievementData.RewardsByRollNumber.GetValueOrDefault(profile.RollNumber) ?? [],
            MockAchievementData.DisciplinesByRollNumber.GetValueOrDefault(profile.RollNumber) ?? []);
    }
}
