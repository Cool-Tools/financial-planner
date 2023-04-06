using FP.Models.Enumerations;

namespace FP.Models.StaticHelpers;

public class ScheduleHelper
{
    public static string ToSchedulePrompt(ScheduleType scheduleType) => scheduleType switch
    {
        ScheduleType.Once => "Once",
        ScheduleType.Annually => "Year(s)",
        ScheduleType.Monthly => "Month(s)",
        ScheduleType.Daily  => "Day(s)",
        ScheduleType.Weekly => "Week(s)",
        ScheduleType.Custom => "Custom",
        _ => throw new ArgumentOutOfRangeException(nameof(scheduleType), $"Unexpected scheduleType value: {scheduleType}")
    };
}