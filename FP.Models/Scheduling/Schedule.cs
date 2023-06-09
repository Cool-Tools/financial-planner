﻿using FP.Models.Enumerations;

namespace FP.Models.Scheduling;

public class Schedule
{
    public DateOnly Date { get; set; }  //  The date of the first (or only) transaction
    public ScheduleType Type { get; set; }  //  How often this transaction repeats
    public SchedulingExceptionRulesCollection? SchedulingRules { get; set; }
    public int Every { get; set; } = 1; // describes how often (every 1 month, 2 weeks, etc)
}

