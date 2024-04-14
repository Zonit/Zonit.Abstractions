namespace Zonit.Abstractions.Settings.Models;

public class SettingModel
{
    public required string Key { get; set; }
    public string? Value { get; set; }
}