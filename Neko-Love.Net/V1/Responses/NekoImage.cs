using Newtonsoft.Json;

namespace Neko_Love.Net.V1.Responses;

/// <summary>
///     Response object for image requests.
/// </summary>
public class NekoImage
{
    public int code { get; set; }
    public string url { get; set; }
}