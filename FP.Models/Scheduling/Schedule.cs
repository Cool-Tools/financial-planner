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
    public IEnumerable<string>? DaysOfTheWeek { get; set; }
    public MonthlySchedule? Monthly { get; set; }
}

public class MonthlySchedule
{
    public IEnumerable<string>? DaysOfTheMonth { get; set; }   //  holds the value for days of the months e.g. 1st, 5th, 25th, Last (32)
    public IEnumerable<int>? Nth { get; set; }   //  holds the value for nth day e.g. 3rd Tuesday of the month
    public IEnumerable<string>? MonthsOfTheYear { get; set; }
    
}
