namespace AvifNet;

public unsafe partial struct avifEncoder
{
    public avifCodecChoice codecChoice;

    public int maxThreads;

    public int speed;

    public int keyframeInterval;

    [NativeTypeName("uint64_t")]
    public ulong timescale;

    public int repetitionCount;

    [NativeTypeName("uint32_t")]
    public uint extraLayerCount;

    public int quality;

    public int qualityAlpha;

    public int minQuantizer;

    public int maxQuantizer;

    public int minQuantizerAlpha;

    public int maxQuantizerAlpha;

    public int tileRowsLog2;

    public int tileColsLog2;

    [NativeTypeName("avifBool")]
    public int autoTiling;

    public avifScalingMode scalingMode;

    public avifIOStats ioStats;

    public avifDiagnostics diag;

    [NativeTypeName("struct avifEncoderData *")]
    public avifEncoderData* data;

    [NativeTypeName("struct avifCodecSpecificOptions *")]
    public avifCodecSpecificOptions* csOptions;

    [NativeTypeName("avifHeaderFormatFlags")]
    public int headerFormat;

    public int qualityGainMap;

    [NativeTypeName("uint64_t")]
    public ulong creationTime;

    [NativeTypeName("uint64_t")]
    public ulong modificationTime;

    public avifSampleTransformRecipe sampleTransformRecipe;
}
