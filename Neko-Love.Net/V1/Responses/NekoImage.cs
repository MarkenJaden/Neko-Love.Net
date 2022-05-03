using Newtonsoft.Json;

namespace Neko_Love.Net.V1.Responses;

/// <summary>
///     Response object for image requests.
/// </summary>
public class NekoImage
{
    [JsonProperty("code")] public int Code { get; set; }
    
    /// <summary>
    ///     Image/GIF URL.
    /// </summary>
    [JsonProperty("url")] public string Url { get; set; }
}