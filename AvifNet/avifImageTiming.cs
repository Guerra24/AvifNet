namespace AvifNet;

public partial struct avifImageTiming
{
    [NativeTypeName("uint64_t")]
    public ulong timescale;

    public double pts;

    [NativeTypeName("uint64_t")]
    public ulong ptsInTimescales;

    public double duration;

    [NativeTypeName("uint64_t")]
    public ulong durationInTimescales;
}
