using FP.Models.Base;

namespace FP.Models;

public class Tag : BaseObject
{
    public string? Name { get; set; }
}

public class TagCollection : List<Tag>
{
}