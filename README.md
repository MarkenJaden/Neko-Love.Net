# :tada: Welcome to `Neko-Love.Net` repository
[![wakatime](https://wakatime.com/badge/user/17f322c9-222a-48b4-9e15-983c41f7aed4/project/d1b281d9-dbaa-4aaf-b59a-0f6baad91dd1.svg)](https://wakatime.com/badge/user/17f322c9-222a-48b4-9e15-983c41f7aed4/project/d1b281d9-dbaa-4aaf-b59a-0f6baad91dd1)
[![GH_UserCount](https://badgen.net/github/dependents-repo/MarkenJaden/Neko-Love.Net)](https://github.com/MarkenJaden/Neko-Love.Net/network/dependents)
[![NG_LatestVersion](https://badgen.net/nuget/v/Neko-Love.Net/latest)](https://www.nuget.org/packages/Neko-Love.Net/)
[![NG_DLCount](https://badgen.net/nuget/dt/Neko-Love.Net)](https://www.nuget.org/packages/Neko-Love.Net/)
[![Discord_MemberCount](https://badgen.net/discord/members/ZZGTwCZprC)](https://discord.gg/ZZGTwCZprC)

`Neko-Love.Net` is an asynchronous library to interact with [Neko-Love](https://neko-love.xyz/) API, currently
supporting v1 API. If you love this repo, consider giving it a star :star:

# :question: How to use
### Version 1
```c#
namespace Hello.There.Nekos;

public class Program
{
    public async Task ExecuteMeAsync()
    {
        NekoV1Client client = new();
        var neko = await client.RequestSfwResultsAsync(SfwEndpoint.Hug);
        var imageUrl = neko.First().Url;
    }
}
```
### With logging (+[Serilog](https://github.com/serilog/serilog))
```c#
namespace Hello.There.Nekos;

public class Program
{
    private NekosV2Client _clientWithLogging;

    public void CreateAClientWithLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();
            
        _clientWithLogging = new(new SerilogLoggerProvider(Log.Logger).CreateLogger("Nekos"));        
    }
}
```
