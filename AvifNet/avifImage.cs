using System.Runtime.CompilerServices;

namespace AvifNet;

public unsafe partial struct avifImage
{
    [NativeTypeName("uint32_t")]
    public uint width;

    [NativeTypeName("uint32_t")]
    public uint height;

    [NativeTypeName("uint32_t")]
    public uint depth;

    public avifPixelFormat yuvFormat;

    public avifRange yuvRange;

    public avifChromaSamplePosition yuvChromaSamplePosition;

    [NativeTypeName("uint8_t *[3]")]
    public _yuvPlanes_e__FixedBuffer yuvPlanes;

    [NativeTypeName("uint32_t[3]")]
    public _yuvRowBytes_e__FixedBuffer yuvRowBytes;

    [NativeTypeName("avifBool")]
    public int imageOwnsYUVPlanes;

    [NativeTypeName("uint8_t *")]
    public byte* alphaPlane;

    [NativeTypeName("uint32_t")]
    public uint alphaRowBytes;

    [NativeTypeName("avifBool")]
    public int imageOwnsAlphaPlane;

    [NativeTypeName("avifBool")]
    public int alphaPremultiplied;

    public avifRWData icc;

    [NativeTypeName("avifColorPrimaries")]
    public ushort colorPrimaries;

    [NativeTypeName("avifTransferCharacteristics")]
    public ushort transferCharacteristics;

    [NativeTypeName("avifMatrixCoefficients")]
    public ushort matrixCoefficients;

    public avifContentLightLevelInformationBox clli;

    [NativeTypeName("avifTransformFlags")]
    public uint transformFlags;

    public avifPixelAspectRatioBox pasp;

    public avifCleanApertureBox clap;

    public avifImageRotation irot;

    public avifImageMirror imir;

    public avifRWData exif;

    public avifRWData xmp;

    public avifImageItemProperty* properties;

    [NativeTypeName("size_t")]
    public nuint numProperties;

    public avifGainMap* gainMap;

    public unsafe partial struct _yuvPlanes_e__FixedBuffer
    {
        public byte* e0;
        public byte* e1;
        public byte* e2;

        public ref byte* this[int index]
        {
            get
            {
                fixed (byte** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    [InlineArray(3)]
    public partial struct _yuvRowBytes_e__FixedBuffer
    {
        public uint e0;
    }
}
