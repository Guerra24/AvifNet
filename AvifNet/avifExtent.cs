namespace AvifNet;

public partial struct avifExtent
{
    [NativeTypeName("uint64_t")]
    public ulong offset;

    [NativeTypeName("size_t")]
    public nuint size;
}
