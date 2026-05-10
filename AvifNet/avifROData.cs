namespace AvifNet;

public unsafe partial struct avifROData
{
    [NativeTypeName("const uint8_t *")]
    public byte* data;

    [NativeTypeName("size_t")]
    public nuint size;
}
