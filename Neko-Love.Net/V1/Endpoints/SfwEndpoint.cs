namespace Neko_Love.Net.V1.Endpoints;

/// <summary>
///     List of SFW endpoints
/// </summary>
[Flags]
public enum SfwEndpoint : ulong
{
    /// <summary>
    ///     Everything except for Random.
    /// </summary>
    /// <seealso cref="Random"/>
    All = 1 << 0,

    /// <summary>
    ///     A random thing.
    ///     Use this if you don't know what to pick.
    /// </summary>
    /// <remarks>May cause infinite loop issue if your luck is terrible.</remarks>
    Random = 1 << 1,

    Neko = 1 << 2,

    Kitsune = 1 << 3,
    
    Hug = 1 << 4,

    Pat = 1 << 5,

    Waifu = 1 << 6,

    Cry = 1 << 7,

    Kiss = 1 << 8,
    
    Slap = 1 << 9,

    Smug = 1 << 10,

    Punch = 1 << 11,
}