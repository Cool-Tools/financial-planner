namespace FP.Models.Enumerations;

public enum ScheduleType
{
    Once,
    Daily,
    Weekly,
    Monthly,
    Annually,
    Nth,    //  For the nth (e.g. 3rd Thursday) of the month
    Custom
}
