using FapSimulator.Api.Models;

namespace FapSimulator.Api.Data;

public static class MockAchievementData
{
    public static readonly IReadOnlyDictionary<string, IReadOnlyList<RewardDto>>
        RewardsByRollNumber =
            new Dictionary<string, IReadOnlyList<RewardDto>>(StringComparer.OrdinalIgnoreCase)
            {
                ["SE180001"] =
        [
            new("AWD001", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180002"] =
        [
            new("AWD002", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180003"] =
        [
            new("AWD003", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180004"] =
        [
            new("AWD004", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180005"] =
        [
            new("AWD005", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180006"] =
        [
            new("AWD006", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180007"] =
        [
            new("AWD007", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180008"] =
        [
            new("AWD008", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180009"] =
        [
            new("AWD009", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180010"] =
        [
            new("AWD010", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180011"] =
        [
            new("AWD011", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180012"] =
        [
            new("AWD012", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180013"] =
        [
            new("AWD013", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180014"] =
        [
            new("AWD014", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180015"] =
        [
            new("AWD015", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180016"] =
        [
            new("AWD016", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180017"] =
        [
            new("AWD017", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180018"] =
        [
            new("AWD018", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180019"] =
        [
            new("AWD019", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
                ["SE180020"] =
        [
            new("AWD020", "Demo Academic Achievement", "Academic", "Spring2026",
                new DateOnly(2026, 5, 15), "Fictional reward for simulator data."),
        ],
            };

    public static readonly IReadOnlyDictionary<string, IReadOnlyList<DisciplineDto>>
        DisciplinesByRollNumber =
            new Dictionary<string, IReadOnlyList<DisciplineDto>>(StringComparer.OrdinalIgnoreCase)
            {
                ["SE180010"] =
        [
            new("DIS001", "Demo Attendance Warning", "Warning", "Spring2026",
                new DateOnly(2026, 3, 10), "Resolved", "Fictional discipline for simulator data."),
        ],
                ["SE180040"] =
        [
            new("DIS002", "Demo Attendance Warning", "Warning", "Spring2026",
                new DateOnly(2026, 3, 10), "Resolved", "Fictional discipline for simulator data."),
        ],
                ["SE190020"] =
        [
            new("DIS003", "Demo Attendance Warning", "Warning", "Spring2026",
                new DateOnly(2026, 3, 10), "Resolved", "Fictional discipline for simulator data."),
        ],
                ["SE190050"] =
        [
            new("DIS004", "Demo Attendance Warning", "Warning", "Spring2026",
                new DateOnly(2026, 3, 10), "Resolved", "Fictional discipline for simulator data."),
        ],
                ["SE200030"] =
        [
            new("DIS005", "Demo Attendance Warning", "Warning", "Spring2026",
                new DateOnly(2026, 3, 10), "Resolved", "Fictional discipline for simulator data."),
        ],
            };
}
