using System.Reflection;
using System.Runtime.InteropServices;

namespace AvifNet;

public static partial class Avif
{
    static Avif()
    {
        NativeLibrary.Load("avif", Assembly.GetExecutingAssembly(), null);
    }
}
