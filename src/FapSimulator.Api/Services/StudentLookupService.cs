using FapSimulator.Api.Data;
using FapSimulator.Api.Models;

namespace FapSimulator.Api.Services;

public sealed class StudentLookupService
{
    private readonly IReadOnlyDictionary<string, StudentProfileDto> profiles =
        MockStudentData.Students.ToDictionary(
            profile => profile.RollNumber,
            StringComparer.OrdinalIgnoreCase);

    public StudentLookupService()
    {
        if (profiles.Count != 150 || MockAcademicData.SemestersByRollNumber.Count != 150)
        {
            throw new InvalidOperationException(
                "FAP Simulator must contain exactly 150 complete student records.");
        }
    }

    public StudentProfileDto? GetProfile(string rollNumber) =>
        profiles.GetValueOrDefault(rollNumber);

    public StudentAcademicRecordDto? GetAcademicRecord(string rollNumber)
    {
        if (!profiles.ContainsKey(rollNumber) ||
            !MockAcademicData.SemestersByRollNumber.TryGetValue(rollNumber, out var semesters))
        {
            return null;
        }

        return AcademicGradeCalculator.BuildRecord(
            profiles[rollNumber].RollNumber,
            semesters,
            MockAchievementData.RewardsByRollNumber.GetValueOrDefault(rollNumber) ?? [],
            MockAchievementData.DisciplinesByRollNumber.GetValueOrDefault(rollNumber) ?? []);
    }
}
