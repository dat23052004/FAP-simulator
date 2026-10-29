namespace FapSimulator.Api.Data;

public static class MockAcademicData
{
    public static readonly IReadOnlyDictionary<string, IReadOnlyList<SemesterSeed>>
        SemestersByRollNumber =
            new Dictionary<string, IReadOnlyList<SemesterSeed>>(StringComparer.OrdinalIgnoreCase)
            {
                ["SE180001"] = AcademicTemplates.GroupAExample,
                ["SE180002"] = AcademicTemplates.GroupAAverage,
                ["SE180003"] = AcademicTemplates.GroupAStrong,
                ["SE180004"] = AcademicTemplates.GroupAAverage,
                ["SE180005"] = AcademicTemplates.GroupAAverage,
                ["SE180006"] = AcademicTemplates.GroupAStrong,
                ["SE180007"] = AcademicTemplates.GroupAAverage,
                ["SE180008"] = AcademicTemplates.GroupAAverage,
                ["SE180009"] = AcademicTemplates.GroupAStrong,
                ["SE180010"] = AcademicTemplates.GroupALow,
                ["SE180011"] = AcademicTemplates.GroupAAverage,
                ["SE180012"] = AcademicTemplates.GroupAStrong,
                ["SE180013"] = AcademicTemplates.GroupAAverage,
                ["SE180014"] = AcademicTemplates.GroupAAverage,
                ["SE180015"] = AcademicTemplates.GroupAStrong,
                ["SE180016"] = AcademicTemplates.GroupAAverage,
                ["SE180017"] = AcademicTemplates.GroupAAverage,
                ["SE180018"] = AcademicTemplates.GroupAStrong,
                ["SE180019"] = AcademicTemplates.GroupAAverage,
                ["SE180020"] = AcademicTemplates.GroupALow,
                ["SE180021"] = AcademicTemplates.GroupAStrong,
                ["SE180022"] = AcademicTemplates.GroupAAverage,
                ["SE180023"] = AcademicTemplates.GroupAAverage,
                ["SE180024"] = AcademicTemplates.GroupAStrong,
                ["SE180025"] = AcademicTemplates.GroupAAverage,
                ["SE180026"] = AcademicTemplates.GroupAAverage,
                ["SE180027"] = AcademicTemplates.GroupAStrong,
                ["SE180028"] = AcademicTemplates.GroupAAverage,
                ["SE180029"] = AcademicTemplates.GroupAAverage,
                ["SE180030"] = AcademicTemplates.GroupALow,
                ["SE180031"] = AcademicTemplates.GroupAAverage,
                ["SE180032"] = AcademicTemplates.GroupAAverage,
                ["SE180033"] = AcademicTemplates.GroupAStrong,
                ["SE180034"] = AcademicTemplates.GroupAAverage,
                ["SE180035"] = AcademicTemplates.GroupAAverage,
                ["SE180036"] = AcademicTemplates.GroupAStrong,
                ["SE180037"] = AcademicTemplates.GroupAAverage,
                ["SE180038"] = AcademicTemplates.GroupAAverage,
                ["SE180039"] = AcademicTemplates.GroupAStrong,
                ["SE180040"] = AcademicTemplates.GroupALow,
                ["SE180041"] = AcademicTemplates.GroupAAverage,
                ["SE180042"] = AcademicTemplates.GroupAStrong,
                ["SE180043"] = AcademicTemplates.GroupAAverage,
                ["SE180044"] = AcademicTemplates.GroupAAverage,
                ["SE180045"] = AcademicTemplates.GroupAStrong,
                ["SE180046"] = AcademicTemplates.GroupAAverage,
                ["SE180047"] = AcademicTemplates.GroupAAverage,
                ["SE180048"] = AcademicTemplates.GroupAStrong,
                ["SE180049"] = AcademicTemplates.GroupAAverage,
                ["SE180050"] = AcademicTemplates.GroupALow,
                ["SE190001"] = AcademicTemplates.GroupBAverage,
                ["SE190002"] = AcademicTemplates.GroupBAverage,
                ["SE190003"] = AcademicTemplates.GroupBStrong,
                ["SE190004"] = AcademicTemplates.GroupBAverage,
                ["SE190005"] = AcademicTemplates.GroupBAverage,
                ["SE190006"] = AcademicTemplates.GroupBStrong,
                ["SE190007"] = AcademicTemplates.GroupBAverage,
                ["SE190008"] = AcademicTemplates.GroupBAverage,
                ["SE190009"] = AcademicTemplates.GroupBStrong,
                ["SE190010"] = AcademicTemplates.GroupBLow,
                ["SE190011"] = AcademicTemplates.GroupBAverage,
                ["SE190012"] = AcademicTemplates.GroupBStrong,
                ["SE190013"] = AcademicTemplates.GroupBAverage,
                ["SE190014"] = AcademicTemplates.GroupBAverage,
                ["SE190015"] = AcademicTemplates.GroupBStrong,
                ["SE190016"] = AcademicTemplates.GroupBAverage,
                ["SE190017"] = AcademicTemplates.GroupBAverage,
                ["SE190018"] = AcademicTemplates.GroupBStrong,
                ["SE190019"] = AcademicTemplates.GroupBAverage,
                ["SE190020"] = AcademicTemplates.GroupBLow,
                ["SE190021"] = AcademicTemplates.GroupBStrong,
                ["SE190022"] = AcademicTemplates.GroupBAverage,
                ["SE190023"] = AcademicTemplates.GroupBAverage,
                ["SE190024"] = AcademicTemplates.GroupBStrong,
                ["SE190025"] = AcademicTemplates.GroupBAverage,
                ["SE190026"] = AcademicTemplates.GroupBAverage,
                ["SE190027"] = AcademicTemplates.GroupBStrong,
                ["SE190028"] = AcademicTemplates.GroupBAverage,
                ["SE190029"] = AcademicTemplates.GroupBAverage,
                ["SE190030"] = AcademicTemplates.GroupBLow,
                ["SE190031"] = AcademicTemplates.GroupBAverage,
                ["SE190032"] = AcademicTemplates.GroupBAverage,
                ["SE190033"] = AcademicTemplates.GroupBStrong,
                ["SE190034"] = AcademicTemplates.GroupBAverage,
                ["SE190035"] = AcademicTemplates.GroupBAverage,
                ["SE190036"] = AcademicTemplates.GroupBStrong,
                ["SE190037"] = AcademicTemplates.GroupBAverage,
                ["SE190038"] = AcademicTemplates.GroupBAverage,
                ["SE190039"] = AcademicTemplates.GroupBStrong,
                ["SE190040"] = AcademicTemplates.GroupBLow,
                ["SE190041"] = AcademicTemplates.GroupBAverage,
                ["SE190042"] = AcademicTemplates.GroupBStrong,
                ["SE190043"] = AcademicTemplates.GroupBAverage,
                ["SE190044"] = AcademicTemplates.GroupBAverage,
                ["SE190045"] = AcademicTemplates.GroupBStrong,
                ["SE190046"] = AcademicTemplates.GroupBAverage,
                ["SE190047"] = AcademicTemplates.GroupBAverage,
                ["SE190048"] = AcademicTemplates.GroupBStrong,
                ["SE190049"] = AcademicTemplates.GroupBAverage,
                ["SE190050"] = AcademicTemplates.GroupBLow,
                ["SE200001"] = AcademicTemplates.GroupCAverage,
                ["SE200002"] = AcademicTemplates.GroupCAverage,
                ["SE200003"] = AcademicTemplates.GroupCStrong,
                ["SE200004"] = AcademicTemplates.GroupCAverage,
                ["SE200005"] = AcademicTemplates.GroupCAverage,
                ["SE200006"] = AcademicTemplates.GroupCStrong,
                ["SE200007"] = AcademicTemplates.GroupCAverage,
                ["SE200008"] = AcademicTemplates.GroupCAverage,
                ["SE200009"] = AcademicTemplates.GroupCStrong,
                ["SE200010"] = AcademicTemplates.GroupCLow,
                ["SE200011"] = AcademicTemplates.GroupCAverage,
                ["SE200012"] = AcademicTemplates.GroupCStrong,
                ["SE200013"] = AcademicTemplates.GroupCAverage,
                ["SE200014"] = AcademicTemplates.GroupCAverage,
                ["SE200015"] = AcademicTemplates.GroupCStrong,
                ["SE200016"] = AcademicTemplates.GroupCAverage,
                ["SE200017"] = AcademicTemplates.GroupCAverage,
                ["SE200018"] = AcademicTemplates.GroupCStrong,
                ["SE200019"] = AcademicTemplates.GroupCAverage,
                ["SE200020"] = AcademicTemplates.GroupCLow,
                ["SE200021"] = AcademicTemplates.GroupCStrong,
                ["SE200022"] = AcademicTemplates.GroupCAverage,
                ["SE200023"] = AcademicTemplates.GroupCAverage,
                ["SE200024"] = AcademicTemplates.GroupCStrong,
                ["SE200025"] = AcademicTemplates.GroupCAverage,
                ["SE200026"] = AcademicTemplates.GroupCAverage,
                ["SE200027"] = AcademicTemplates.GroupCStrong,
                ["SE200028"] = AcademicTemplates.GroupCAverage,
                ["SE200029"] = AcademicTemplates.GroupCAverage,
                ["SE200030"] = AcademicTemplates.GroupCLow,
                ["SE200031"] = AcademicTemplates.GroupCAverage,
                ["SE200032"] = AcademicTemplates.GroupCAverage,
                ["SE200033"] = AcademicTemplates.GroupCStrong,
                ["SE200034"] = AcademicTemplates.GroupCAverage,
                ["SE200035"] = AcademicTemplates.GroupCAverage,
                ["SE200036"] = AcademicTemplates.GroupCStrong,
                ["SE200037"] = AcademicTemplates.GroupCAverage,
                ["SE200038"] = AcademicTemplates.GroupCAverage,
                ["SE200039"] = AcademicTemplates.GroupCStrong,
                ["SE200040"] = AcademicTemplates.GroupCLow,
                ["SE200041"] = AcademicTemplates.GroupCAverage,
                ["SE200042"] = AcademicTemplates.GroupCStrong,
                ["SE200043"] = AcademicTemplates.GroupCAverage,
                ["SE200044"] = AcademicTemplates.GroupCAverage,
                ["SE200045"] = AcademicTemplates.GroupCStrong,
                ["SE200046"] = AcademicTemplates.GroupCAverage,
                ["SE200047"] = AcademicTemplates.GroupCAverage,
                ["SE200048"] = AcademicTemplates.GroupCStrong,
                ["SE200049"] = AcademicTemplates.GroupCAverage,
                ["SE200050"] = AcademicTemplates.GroupCLow,
            };
}

internal static class AcademicTemplates
{
    public static readonly IReadOnlyList<SemesterSeed> GroupAExample =
    [
        new("Fall2025", "Fall 2025",
        [
            new("PRF192", "Programming Fundamentals", 3, 8.6m),
            new("MAE101", "Mathematics", 3, 7.8m),
            new("CSI104", "Computer Science", 3, 8.2m),
            new("SSL101", "Study Skills", 2, 9.2m),
        ]),
        new("Spring2026", "Spring 2026",
        [
            new("PRO192", "Object-Oriented Programming", 3, 8.4m),
            new("DBI202", "Database Systems", 3, 7.9m),
            new("MAD101", "Discrete Mathematics", 3, 8.7m),
            new("CEA201", "Computer Architecture", 2, 6.8m),
        ]),
        new("Summer2026", "Summer 2026",
        [
            new("PRN212", "Cross-Platform .NET Programming", 3, 9.0m),
            new("SWE201c", "Software Engineering", 3, 8.1m),
            new("SWP391", "Software Project", 3, 9.1m),
            new("JPD113", "Japanese", 3, 7.2m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupAStrong =
    [
        new("Fall2025", "Fall 2025",
        [
            new("PRF192", "Programming Fundamentals", 3, 9.1m),
            new("MAE101", "Mathematics", 3, 8.6m),
            new("CSI104", "Computer Science", 3, 8.8m),
            new("SSL101", "Study Skills", 2, 9.0m),
        ]),
        new("Spring2026", "Spring 2026",
        [
            new("PRO192", "Object-Oriented Programming", 3, 8.8m),
            new("DBI202", "Database Systems", 3, 8.5m),
            new("MAD101", "Discrete Mathematics", 3, 8.2m),
            new("CEA201", "Computer Architecture", 2, 7.9m),
        ]),
        new("Summer2026", "Summer 2026",
        [
            new("PRN212", "Cross-Platform .NET Programming", 3, 9.2m),
            new("SWE201c", "Software Engineering", 3, 8.7m),
            new("SWP391", "Software Project", 3, 9.3m),
            new("JPD113", "Japanese", 3, 8.1m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupAAverage =
    [
        new("Fall2025", "Fall 2025",
        [
            new("PRF192", "Programming Fundamentals", 3, 7.4m),
            new("MAE101", "Mathematics", 3, 6.8m),
            new("CSI104", "Computer Science", 3, 7.1m),
            new("SSL101", "Study Skills", 2, 8.0m),
        ]),
        new("Spring2026", "Spring 2026",
        [
            new("PRO192", "Object-Oriented Programming", 3, 7.3m),
            new("DBI202", "Database Systems", 3, 6.5m),
            new("MAD101", "Discrete Mathematics", 3, 7.0m),
            new("CEA201", "Computer Architecture", 2, 6.2m),
        ]),
        new("Summer2026", "Summer 2026",
        [
            new("PRN212", "Cross-Platform .NET Programming", 3, 7.8m),
            new("SWE201c", "Software Engineering", 3, 7.2m),
            new("SWP391", "Software Project", 3, 8.0m),
            new("JPD113", "Japanese", 3, 6.7m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupALow =
    [
        new("Fall2025", "Fall 2025",
        [
            new("PRF192", "Programming Fundamentals", 3, 5.8m),
            new("MAE101", "Mathematics", 3, 4.6m),
            new("CSI104", "Computer Science", 3, 6.0m),
            new("SSL101", "Study Skills", 2, 5.2m),
        ]),
        new("Spring2026", "Spring 2026",
        [
            new("PRO192", "Object-Oriented Programming", 3, 5.4m),
            new("DBI202", "Database Systems", 3, 4.8m),
            new("MAD101", "Discrete Mathematics", 3, 5.1m),
            new("CEA201", "Computer Architecture", 2, 6.0m),
        ]),
        new("Summer2026", "Summer 2026",
        [
            new("PRN212", "Cross-Platform .NET Programming", 3, 5.7m),
            new("SWE201c", "Software Engineering", 3, 5.0m),
            new("SWP391", "Software Project", 3, 6.2m),
            new("JPD113", "Japanese", 3, 4.4m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupBStrong =
    [
        new("Spring2026", "Spring 2026",
        [
            new("PRF192", "Programming Fundamentals", 3, 8.9m),
            new("MAE101", "Mathematics", 3, 8.4m),
            new("CSI104", "Computer Science", 3, 9.0m),
            new("SSL101", "Study Skills", 2, 8.7m),
        ]),
        new("Summer2026", "Summer 2026",
        [
            new("PRO192", "Object-Oriented Programming", 3, 9.1m),
            new("DBI202", "Database Systems", 3, 8.8m),
            new("MAD101", "Discrete Mathematics", 3, 8.3m),
            new("CEA201", "Computer Architecture", 2, 8.0m),
        ]),
        new("Fall2026", "Fall 2026",
        [
            new("IOT102", "Internet of Things", 3, 8.6m),
            new("NET201", "Computer Networks", 3, 8.9m),
            new("OSG202", "Operating Systems", 3, 8.2m),
            new("SWP391", "Software Project", 3, 9.2m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupBAverage =
    [
        new("Spring2026", "Spring 2026",
        [
            new("PRF192", "Programming Fundamentals", 3, 7.1m),
            new("MAE101", "Mathematics", 3, 6.7m),
            new("CSI104", "Computer Science", 3, 7.5m),
            new("SSL101", "Study Skills", 2, 7.8m),
        ]),
        new("Summer2026", "Summer 2026",
        [
            new("PRO192", "Object-Oriented Programming", 3, 7.0m),
            new("DBI202", "Database Systems", 3, 6.8m),
            new("MAD101", "Discrete Mathematics", 3, 6.4m),
            new("CEA201", "Computer Architecture", 2, 6.6m),
        ]),
        new("Fall2026", "Fall 2026",
        [
            new("IOT102", "Internet of Things", 3, 7.2m),
            new("NET201", "Computer Networks", 3, 6.9m),
            new("OSG202", "Operating Systems", 3, 7.4m),
            new("SWP391", "Software Project", 3, 7.9m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupBLow =
    [
        new("Spring2026", "Spring 2026",
        [
            new("PRF192", "Programming Fundamentals", 3, 5.6m),
            new("MAE101", "Mathematics", 3, 4.5m),
            new("CSI104", "Computer Science", 3, 5.3m),
            new("SSL101", "Study Skills", 2, 6.1m),
        ]),
        new("Summer2026", "Summer 2026",
        [
            new("PRO192", "Object-Oriented Programming", 3, 5.0m),
            new("DBI202", "Database Systems", 3, 4.7m),
            new("MAD101", "Discrete Mathematics", 3, 5.5m),
            new("CEA201", "Computer Architecture", 2, 5.8m),
        ]),
        new("Fall2026", "Fall 2026",
        [
            new("IOT102", "Internet of Things", 3, 6.0m),
            new("NET201", "Computer Networks", 3, 5.2m),
            new("OSG202", "Operating Systems", 3, 4.3m),
            new("SWP391", "Software Project", 3, 6.4m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupCStrong =
    [
        new("Summer2026", "Summer 2026",
        [
            new("AIG202", "Artificial Intelligence", 3, 9.0m),
            new("MAS291", "Statistics", 3, 8.7m),
            new("DBI202", "Database Systems", 3, 8.8m),
        ]),
        new("Fall2026", "Fall 2026",
        [
            new("DPL302", "Deep Learning", 3, 8.9m),
            new("CPV301", "Computer Vision", 3, 8.5m),
            new("NLP301", "Natural Language Processing", 3, 9.1m),
            new("AIL303", "AI Lab", 3, 9.3m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupCAverage =
    [
        new("Summer2026", "Summer 2026",
        [
            new("AIG202", "Artificial Intelligence", 3, 7.3m),
            new("MAS291", "Statistics", 3, 6.9m),
            new("DBI202", "Database Systems", 3, 7.0m),
        ]),
        new("Fall2026", "Fall 2026",
        [
            new("DPL302", "Deep Learning", 3, 7.2m),
            new("CPV301", "Computer Vision", 3, 6.7m),
            new("NLP301", "Natural Language Processing", 3, 7.5m),
            new("AIL303", "AI Lab", 3, 7.8m),
        ]),
    ];

    public static readonly IReadOnlyList<SemesterSeed> GroupCLow =
    [
        new("Summer2026", "Summer 2026",
        [
            new("AIG202", "Artificial Intelligence", 3, 5.4m),
            new("MAS291", "Statistics", 3, 4.2m),
            new("DBI202", "Database Systems", 3, 5.7m),
        ]),
        new("Fall2026", "Fall 2026",
        [
            new("DPL302", "Deep Learning", 3, 5.1m),
            new("CPV301", "Computer Vision", 3, 4.6m),
            new("NLP301", "Natural Language Processing", 3, 5.8m),
            new("AIL303", "AI Lab", 3, 6.0m),
        ]),
    ];
}
