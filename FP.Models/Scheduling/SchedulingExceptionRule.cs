namespace FP.Models.Scheduling;

public class SchedulingExceptionRulesCollection : List<SchedulingExceptionRule>  {
}

public class SchedulingExceptionRule
{
    public int Order { get; set; }
    public int Condition { get; set; }
    public int? MoveToPreviousDayOfWeek { get; set; }
    public int? MoveToNextDayOfWeek { get; set; }
}