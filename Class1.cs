using CounterStrikeSharp.API.Core;

namespace cs2plugin;

public class Class1: BasePlugin
{
    public override string ModuleName => "Hello World Plugin";

    public override string ModuleVersion => "0.0.1";

    public override void Load(bool hotReload)
    {
        Console.WriteLine("Hello World!");
    }
}