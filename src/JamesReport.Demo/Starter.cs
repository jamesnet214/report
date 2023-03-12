using JamesReport.Settings;
using System;

namespace JamesReport.Demo;

public class Starter
{
    [STAThread]
     private static void Main(string[] args)
    {
        _ = new App()
            .AddWireDataContext<WireDataContext>()
            .AddInversionModule<ViewModules>()
            .AddInversionModule<DirectModules>()
            .Run();
    }
}
