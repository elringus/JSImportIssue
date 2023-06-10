using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

await JSHost.ImportAsync("ModuleId", "./main.js");

[SupportedOSPlatform("browser")]
public static partial class Program
{
    [JSImport("importString", "ModuleId")]
    public static partial string ImportString ();

    [JSExport]
    public static string GetImportedString () => ImportString();
}
