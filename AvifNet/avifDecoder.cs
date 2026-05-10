namespace AvifNet;

public unsafe partial struct avifDecoder
{
    public avifCodecChoice codecChoice;

    public int maxThreads;

    public avifDecoderSource requestedSource;

    [NativeTypeName("avifBool")]
    public int allowProgressive;

    [NativeTypeName("avifBool")]
    public int allowIncremental;

    [NativeTypeName("avifBool")]
    public int ignoreExif;

    [NativeTypeName("avifBool")]
    public int ignoreXMP;

    [NativeTypeName("uint32_t")]
    public uint imageSizeLimit;

    [NativeTypeName("uint32_t")]
    public uint imageDimensionLimit;

    [NativeTypeName("uint32_t")]
    public uint imageCountLimit;

    [NativeTypeName("avifStrictFlags")]
    public uint strictFlags;

    public avifImage* image;

    public int imageIndex;

    public int imageCount;

    public avifProgressiveState progressiveState;

    public avifImageTiming imageTiming;

    [NativeTypeName("uint64_t")]
    public ulong timescale;

    public double duration;

    [NativeTypeName("uint64_t")]
    public ulong durationInTimescales;

    public int repetitionCount;

    [NativeTypeName("avifBool")]
    public int alphaPresent;

    public avifIOStats ioStats;

    public avifDiagnostics diag;

    public avifIO* io;

    [NativeTypeName("struct avifDecoderData *")]
    public avifDecoderData* data;

    [NativeTypeName("avifBool")]
    public int imageSequenceTrackPresent;

    [NativeTypeName("avifImageContentTypeFlags")]
    public uint imageContentToDecode;
}
