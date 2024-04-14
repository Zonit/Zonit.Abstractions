namespace Zonit.Abstractions.Culture;

public interface ICulture
{
    /// <summary>
    /// Zwraca aktualną używaną kulturę w standardzie BCP 47
    /// </summary>
    public string GetCulture { get; }

    /// <summary>
    /// Zwraca tłumaczenie w obecnym używanym języku
    /// </summary>
    /// <param name="content">Szukany ciąg, przykład: "Hello {0}"</param>
    /// <param name="args">Dodatkowe argumenty, przykład: "User"</param>
    /// <returns></returns>
    public string Translate(string content, params object?[] args);

    /// <summary>
    /// Zmienia język
    /// </summary>
    /// <param name="culture">Parametr językowy w standardzie BCP 47</param>
    public void SetCulture(string culture);

    public event Action? OnChange;
}