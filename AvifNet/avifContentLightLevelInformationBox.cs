namespace AvifNet;

public partial struct avifContentLightLevelInformationBox
{
    [NativeTypeName("uint16_t")]
    public ushort maxCLL;

    [NativeTypeName("uint16_t")]
    public ushort maxPALL;
}
