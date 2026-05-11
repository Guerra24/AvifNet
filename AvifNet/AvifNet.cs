using System.Reflection;
using System.Runtime.InteropServices;

namespace AvifNet;

public static partial class Avif
{
    public static bool IsAvailable { get; }

    static Avif()
    {
        try
        {
            NativeLibrary.Load("avif", Assembly.GetExecutingAssembly(), null);
            IsAvailable = true;
        }
        catch { }
    }
}
