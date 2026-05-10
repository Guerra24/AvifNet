using System.Runtime.InteropServices;

namespace AvifNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void avifIODestroyFunc([NativeTypeName("struct avifIO *")] avifIO* io);
