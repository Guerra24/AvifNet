namespace AvifNet;

public unsafe partial struct avifRGBImage
{
    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("uint32_t")]
    public uint depth;

    public avifRGBFormat format;

    public avifChromaUpsampling chromaUpsampling;

    public avifChromaDownsampling chromaDownsampling;

    [NativeTypeName("avifBool")]
    public int avoidLibYUV;

    [NativeTypeName("avifBool")]
    public int ignoreAlpha;

    [NativeTypeName("avifBool")]
    public int alphaPremultiplied;

    [NativeTypeName("avifBool")]
    public int isFloat;

    public int maxThreads;

    [NativeTypeName("uint8_t *")]
    public byte* pixels;

    [NativeTypeName("uint32_t")]
    public uint rowBytes;
}
