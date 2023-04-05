using FP.Models.Enumerations;

namespace FP.Models.Scheduling;

public class Schedule
{
    public DateOnly Date { get; set; }
    public ScheduleType Type { get; set; }
    public SchedulingExceptionRulesCollection? SchedulingRules { get; set; }
}

