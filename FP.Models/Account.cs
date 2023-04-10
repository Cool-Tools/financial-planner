using FP.Models.Base;

namespace FP.Models;

public class Account : BaseObject
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? SortCode { get; set; }
    public string? AccountNo { get; set; }
    public Address? Address { get; set; }
    public TagCollection? Tags { get; set; }
}