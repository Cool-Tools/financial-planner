using FP.Models.Enumerations;

namespace FP.Models.Scheduling;

public class Schedule
{
    public DateTime? StartDate { get; set; }  //  The date of the first (or only) transaction
    public int RepeatCount { get; set; }    //  How many times the schedule repeats
    public DateTime? EndDate { get; set; }  //  The date of the last transaction if end date is selected
    public ScheduleType Type { get; set; }  //  How often this transaction repeats
    public SchedulingExceptionRulesCollection? SchedulingRules { get; set; }
    public int Every { get; set; } = 1; // describes how often (every 1 month, 2 weeks, etc)
    public int Nth { get; set; } = 2;   //  holds the value for nth day e.g. 3rd Tuesday of the month
    public IEnumerable<string>? DaysOfTheWeek { get; set; }
    // public IEnumerable<string>? MonthsOfTheYear { get; set; }
}

