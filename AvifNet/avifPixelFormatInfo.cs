namespace AvifNet;

public partial struct avifPixelFormatInfo
{
    [NativeTypeName("avifBool")]
    public int monochrome;

    public int chromaShiftX;

    public int chromaShiftY;
}
