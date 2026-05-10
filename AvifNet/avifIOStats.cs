namespace AvifNet;

public partial struct avifIOStats
{
    [NativeTypeName("size_t")]
    public nuint colorOBUSize;

    [NativeTypeName("size_t")]
    public nuint alphaOBUSize;
}
