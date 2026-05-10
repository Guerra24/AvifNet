using System.Runtime.CompilerServices;

namespace AvifNet;

public unsafe partial struct avifGainMap
{
    [NativeTypeName("struct avifImage *")]
    public avifImage* image;

    [NativeTypeName("avifSignedFraction[3]")]
    public _gainMapMin_e__FixedBuffer gainMapMin;

    [NativeTypeName("avifSignedFraction[3]")]
    public _gainMapMax_e__FixedBuffer gainMapMax;

    [NativeTypeName("avifUnsignedFraction[3]")]
    public _gainMapGamma_e__FixedBuffer gainMapGamma;

    [NativeTypeName("avifSignedFraction[3]")]
    public _baseOffset_e__FixedBuffer baseOffset;

    [NativeTypeName("avifSignedFraction[3]")]
    public _alternateOffset_e__FixedBuffer alternateOffset;

    public avifUnsignedFraction baseHdrHeadroom;

    public avifUnsignedFraction alternateHdrHeadroom;

    [NativeTypeName("avifBool")]
    public int useBaseColorSpace;

    public avifRWData altICC;

    [NativeTypeName("avifColorPrimaries")]
    public ushort altColorPrimaries;

    [NativeTypeName("avifTransferCharacteristics")]
    public ushort altTransferCharacteristics;

    [NativeTypeName("avifMatrixCoefficients")]
    public ushort altMatrixCoefficients;

    public avifRange altYUVRange;

    [NativeTypeName("uint32_t")]
    public uint altDepth;

    [NativeTypeName("uint32_t")]
    public uint altPlaneCount;

    public avifContentLightLevelInformationBox altCLLI;

    [InlineArray(3)]
    public partial struct _gainMapMin_e__FixedBuffer
    {
        public avifSignedFraction e0;
    }

    [InlineArray(3)]
    public partial struct _gainMapMax_e__FixedBuffer
    {
        public avifSignedFraction e0;
    }

    [InlineArray(3)]
    public partial struct _gainMapGamma_e__FixedBuffer
    {
        public avifUnsignedFraction e0;
    }

    [InlineArray(3)]
    public partial struct _baseOffset_e__FixedBuffer
    {
        public avifSignedFraction e0;
    }

    [InlineArray(3)]
    public partial struct _alternateOffset_e__FixedBuffer
    {
        public avifSignedFraction e0;
    }
}
