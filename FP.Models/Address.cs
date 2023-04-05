namespace FP.Models;

public class Address
{
    public string? HouseNameOrNumber { get; set; }
    public List<string>? AddressLine { get; set; }
    public string? PostcodeOrZip { get; set; }
}