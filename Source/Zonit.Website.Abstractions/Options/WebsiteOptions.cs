namespace Zonit.Website.Abstractions.Options;

/// <summary>
/// Website options
/// </summary>
public class WebsiteOptions
{
    /// <summary>
    /// Specify the urls the web host will listen on.
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// Token for authorization
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    /// Applies forwarded headers to their matching fields on the current request. <br/>
    /// By convention, HTTP proxies forward information from the client in well-known <br/>
    /// HTTP headers. The Microsoft.AspNetCore.HttpOverrides.ForwardedHeadersMiddleware <br/>
    /// reads these headers and fills in the associated fields on HttpContext.
    /// </summary>
    public bool Proxy { get; set; } = false;
}