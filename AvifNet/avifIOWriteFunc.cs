using System.Runtime.InteropServices;

namespace AvifNet;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate avifResult avifIOWriteFunc([NativeTypeName("struct avifIO *")] avifIO* io, [NativeTypeName("uint32_t")] uint writeFlags, [NativeTypeName("uint64_t")] ulong offset, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);
