namespace Zonit.Abstractions.Settings;

public interface ISetting
{
    public string? Get(string key);
    public bool Set(string key, string value);
}
