namespace FP.Models.Scheduling;

public abstract class SchedulingExceptionRulesCollection : List<SchedulingExceptionRule>  {
}

public abstract class SchedulingExceptionRule
{
    public int Order { get; set; } // This sets the precedence of the rule - the order they are applied in
    public int Condition { get; set; }
    public int? MoveToPreviousDayOfWeek { get; set; }
    public int? MoveToNextDayOfWeek { get; set; }
}