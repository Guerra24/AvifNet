using System.Runtime.InteropServices;

namespace AvifNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate avifResult avifIOReadFunc([NativeTypeName("struct avifIO *")] avifIO* io, [NativeTypeName("uint32_t")] uint readFlags, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("size_t")] nuint size, avifROData* @out);
