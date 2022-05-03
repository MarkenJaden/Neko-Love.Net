namespace Neko_Love.Net.V1.Endpoints;

/// <summary>
///     List of NSFW endpoints
/// </summary>
[Flags]
public enum NsfwEndpoint : ulong
{
    /// <summary>
    ///     Everything except for Random.
    /// </summary>
    /// <seealso cref="Random"/>
    All = 1 << 0,

    /// <summary>
    ///     A random endpoint.
    ///     Use this if you don't know what to pick.
    /// </summary>
    /// <remarks>May cause infinite loop issue if your luck is terrible.</remarks>
    Random = 1 << 1,

    Nekolewd = 1 << 2,
}