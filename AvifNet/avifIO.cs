using System;

namespace AvifNet;

public unsafe partial struct avifIO
{
    [NativeTypeName("avifIODestroyFunc")]
    public IntPtr destroy;

    [NativeTypeName("avifIOReadFunc")]
    public IntPtr read;

    [NativeTypeName("avifIOWriteFunc")]
    public IntPtr write;

    [NativeTypeName("uint64_t")]
    public ulong sizeHint;

    [NativeTypeName("avifBool")]
    public int persistent;

    public void* data;
}
