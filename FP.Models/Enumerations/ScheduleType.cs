namespace FP.Models.Enumerations;

public enum ScheduleType
{
    Once,
    Daily,
    Weekly,
    Monthly,
    Annually,
    Last,   //  For last day (e.g. Friday) of the month
    First,  //  For the first (e.g. Monday) of the month
    Nth,    //  For the nth (e.g. 3rd Thursday) of the month
    Custom
}
