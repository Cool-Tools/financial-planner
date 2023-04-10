namespace FP.Models.Base;

public class BaseObject
{
    private Guid Id { get; init; }

    protected BaseObject()
    {
        Id = Guid.NewGuid();
    }
}