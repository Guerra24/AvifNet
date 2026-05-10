namespace AvifNet;

public unsafe partial struct avifRWData
{
    [NativeTypeName("uint8_t *")]
    public byte* data;

    [NativeTypeName("size_t")]
    public nuint size;
}
