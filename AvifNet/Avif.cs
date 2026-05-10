using System.Runtime.InteropServices;

namespace AvifNet;

public static unsafe partial class Avif
{
    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* avifVersion();

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifCodecVersions([NativeTypeName("char[256]")] sbyte* outBuffer);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint avifLibYUVVersion();

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* avifAlloc([NativeTypeName("size_t")] nuint size);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifFree(void* p);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* avifResultToString(avifResult result);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifRWDataRealloc(avifRWData* raw, [NativeTypeName("size_t")] nuint newSize);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifRWDataSet(avifRWData* raw, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint len);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifRWDataFree(avifRWData* raw);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifGetExifTiffHeaderOffset([NativeTypeName("const uint8_t *")] byte* exif, [NativeTypeName("size_t")] nuint exifSize, [NativeTypeName("size_t *")] nuint* offset);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifGetExifOrientationOffset([NativeTypeName("const uint8_t *")] byte* exif, [NativeTypeName("size_t")] nuint exifSize, [NativeTypeName("size_t *")] nuint* offset);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* avifPixelFormatToString(avifPixelFormat format);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifGetPixelFormatInfo(avifPixelFormat format, avifPixelFormatInfo* info);

    public const int AVIF_COLOR_PRIMARIES_UNKNOWN = 0;
    public const int AVIF_COLOR_PRIMARIES_BT709 = 1;
    public const int AVIF_COLOR_PRIMARIES_SRGB = 1;
    public const int AVIF_COLOR_PRIMARIES_IEC61966_2_4 = 1;
    public const int AVIF_COLOR_PRIMARIES_UNSPECIFIED = 2;
    public const int AVIF_COLOR_PRIMARIES_BT470M = 4;
    public const int AVIF_COLOR_PRIMARIES_BT470BG = 5;
    public const int AVIF_COLOR_PRIMARIES_BT601 = 6;
    public const int AVIF_COLOR_PRIMARIES_SMPTE240 = 7;
    public const int AVIF_COLOR_PRIMARIES_GENERIC_FILM = 8;
    public const int AVIF_COLOR_PRIMARIES_BT2020 = 9;
    public const int AVIF_COLOR_PRIMARIES_BT2100 = 9;
    public const int AVIF_COLOR_PRIMARIES_XYZ = 10;
    public const int AVIF_COLOR_PRIMARIES_SMPTE431 = 11;
    public const int AVIF_COLOR_PRIMARIES_SMPTE432 = 12;
    public const int AVIF_COLOR_PRIMARIES_DCI_P3 = 12;
    public const int AVIF_COLOR_PRIMARIES_EBU3213 = 22;

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifColorPrimariesGetValues([NativeTypeName("avifColorPrimaries")] ushort acp, [NativeTypeName("float[8]")] float* outPrimaries);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifColorPrimaries")]
    public static extern ushort avifColorPrimariesFind([NativeTypeName("const float[8]")] float* inPrimaries, [NativeTypeName("const char **")] sbyte** outName);

    public const int AVIF_TRANSFER_CHARACTERISTICS_UNKNOWN = 0;
    public const int AVIF_TRANSFER_CHARACTERISTICS_BT709 = 1;
    public const int AVIF_TRANSFER_CHARACTERISTICS_UNSPECIFIED = 2;
    public const int AVIF_TRANSFER_CHARACTERISTICS_BT470M = 4;
    public const int AVIF_TRANSFER_CHARACTERISTICS_BT470BG = 5;
    public const int AVIF_TRANSFER_CHARACTERISTICS_BT601 = 6;
    public const int AVIF_TRANSFER_CHARACTERISTICS_SMPTE240 = 7;
    public const int AVIF_TRANSFER_CHARACTERISTICS_LINEAR = 8;
    public const int AVIF_TRANSFER_CHARACTERISTICS_LOG100 = 9;
    public const int AVIF_TRANSFER_CHARACTERISTICS_LOG100_SQRT10 = 10;
    public const int AVIF_TRANSFER_CHARACTERISTICS_IEC61966 = 11;
    public const int AVIF_TRANSFER_CHARACTERISTICS_BT1361 = 12;
    public const int AVIF_TRANSFER_CHARACTERISTICS_SRGB = 13;
    public const int AVIF_TRANSFER_CHARACTERISTICS_BT2020_10BIT = 14;
    public const int AVIF_TRANSFER_CHARACTERISTICS_BT2020_12BIT = 15;
    public const int AVIF_TRANSFER_CHARACTERISTICS_PQ = 16;
    public const int AVIF_TRANSFER_CHARACTERISTICS_SMPTE2084 = 16;
    public const int AVIF_TRANSFER_CHARACTERISTICS_SMPTE428 = 17;
    public const int AVIF_TRANSFER_CHARACTERISTICS_HLG = 18;

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifTransferCharacteristicsGetGamma([NativeTypeName("avifTransferCharacteristics")] ushort atc, float* gamma);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifTransferCharacteristics")]
    public static extern ushort avifTransferCharacteristicsFindByGamma(float gamma);

    public const int AVIF_MATRIX_COEFFICIENTS_IDENTITY = 0;
    public const int AVIF_MATRIX_COEFFICIENTS_BT709 = 1;
    public const int AVIF_MATRIX_COEFFICIENTS_UNSPECIFIED = 2;
    public const int AVIF_MATRIX_COEFFICIENTS_FCC = 4;
    public const int AVIF_MATRIX_COEFFICIENTS_BT470BG = 5;
    public const int AVIF_MATRIX_COEFFICIENTS_BT601 = 6;
    public const int AVIF_MATRIX_COEFFICIENTS_SMPTE240 = 7;
    public const int AVIF_MATRIX_COEFFICIENTS_YCGCO = 8;
    public const int AVIF_MATRIX_COEFFICIENTS_BT2020_NCL = 9;
    public const int AVIF_MATRIX_COEFFICIENTS_BT2020_CL = 10;
    public const int AVIF_MATRIX_COEFFICIENTS_SMPTE2085 = 11;
    public const int AVIF_MATRIX_COEFFICIENTS_CHROMA_DERIVED_NCL = 12;
    public const int AVIF_MATRIX_COEFFICIENTS_CHROMA_DERIVED_CL = 13;
    public const int AVIF_MATRIX_COEFFICIENTS_ICTCP = 14;
    public const int AVIF_MATRIX_COEFFICIENTS_YCGCO_RE = 16;
    public const int AVIF_MATRIX_COEFFICIENTS_YCGCO_RO = 17;
    public const int AVIF_MATRIX_COEFFICIENTS_LAST = 18;

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifDiagnosticsClearError(avifDiagnostics* diag);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifDoubleToSignedFraction(double v, avifSignedFraction* fraction);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifDoubleToUnsignedFraction(double v, avifUnsignedFraction* fraction);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifCropRectFromCleanApertureBox(avifCropRect* cropRect, [NativeTypeName("const avifCleanApertureBox *")] avifCleanApertureBox* clap, [NativeTypeName("uint32_t")] uint imageW, [NativeTypeName("uint32_t")] uint imageH, avifDiagnostics* diag);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifCleanApertureBoxFromCropRect(avifCleanApertureBox* clap, [NativeTypeName("const avifCropRect *")] avifCropRect* cropRect, [NativeTypeName("uint32_t")] uint imageW, [NativeTypeName("uint32_t")] uint imageH, avifDiagnostics* diag);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifCropRectRequiresUpsampling([NativeTypeName("const avifCropRect *")] avifCropRect* cropRect, avifPixelFormat yuvFormat);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifCropRectConvertCleanApertureBox(avifCropRect* param0, [NativeTypeName("const avifCleanApertureBox *")] avifCleanApertureBox* param1, [NativeTypeName("uint32_t")] uint param2, [NativeTypeName("uint32_t")] uint param3, avifPixelFormat param4, avifDiagnostics* param5);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifCleanApertureBoxConvertCropRect(avifCleanApertureBox* param0, [NativeTypeName("const avifCropRect *")] avifCropRect* param1, [NativeTypeName("uint32_t")] uint param2, [NativeTypeName("uint32_t")] uint param3, avifPixelFormat param4, avifDiagnostics* param5);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifGainMap* avifGainMapCreate();

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifGainMapDestroy(avifGainMap* gainMap);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifImage* avifImageCreate([NativeTypeName("uint32_t")] uint width, [NativeTypeName("uint32_t")] uint height, [NativeTypeName("uint32_t")] uint depth, avifPixelFormat yuvFormat);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifImage* avifImageCreateEmpty();

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageCopy(avifImage* dstImage, [NativeTypeName("const avifImage *")] avifImage* srcImage, [NativeTypeName("avifPlanesFlags")] uint planes);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageSetViewRect(avifImage* dstImage, [NativeTypeName("const avifImage *")] avifImage* srcImage, [NativeTypeName("const avifCropRect *")] avifCropRect* rect);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifImageDestroy(avifImage* image);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageSetProfileICC(avifImage* image, [NativeTypeName("const uint8_t *")] byte* icc, [NativeTypeName("size_t")] nuint iccSize);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageSetMetadataExif(avifImage* image, [NativeTypeName("const uint8_t *")] byte* exif, [NativeTypeName("size_t")] nuint exifSize);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageSetMetadataXMP(avifImage* image, [NativeTypeName("const uint8_t *")] byte* xmp, [NativeTypeName("size_t")] nuint xmpSize);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageAllocatePlanes(avifImage* image, [NativeTypeName("avifPlanesFlags")] uint planes);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifImageFreePlanes(avifImage* image, [NativeTypeName("avifPlanesFlags")] uint planes);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifImageStealPlanes(avifImage* dstImage, avifImage* srcImage, [NativeTypeName("avifPlanesFlags")] uint planes);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageAddOpaqueProperty(avifImage* image, [NativeTypeName("const uint8_t[4]")] byte* boxtype, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint dataSize);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageAddUUIDProperty(avifImage* image, [NativeTypeName("const uint8_t[16]")] byte* uuid, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint dataSize);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageScale(avifImage* image, [NativeTypeName("uint32_t")] uint dstWidth, [NativeTypeName("uint32_t")] uint dstHeight, avifDiagnostics* diag);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint avifRGBFormatChannelCount(avifRGBFormat format);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifRGBFormatHasAlpha(avifRGBFormat format);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifRGBFormatIsGray(avifRGBFormat format);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifRGBImageSetDefaults(avifRGBImage* rgb, [NativeTypeName("const avifImage *")] avifImage* image);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint avifRGBImagePixelSize([NativeTypeName("const avifRGBImage *")] avifRGBImage* rgb);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifRGBImageAllocatePixels(avifRGBImage* rgb);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifRGBImageFreePixels(avifRGBImage* rgb);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageRGBToYUV(avifImage* image, [NativeTypeName("const avifRGBImage *")] avifRGBImage* rgb);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageYUVToRGB([NativeTypeName("const avifImage *")] avifImage* image, avifRGBImage* rgb);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifRGBImagePremultiplyAlpha(avifRGBImage* rgb);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifRGBImageUnpremultiplyAlpha(avifRGBImage* rgb);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int avifFullToLimitedY([NativeTypeName("uint32_t")] uint depth, int v);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int avifFullToLimitedUV([NativeTypeName("uint32_t")] uint depth, int v);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int avifLimitedToFullY([NativeTypeName("uint32_t")] uint depth, int v);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int avifLimitedToFullUV([NativeTypeName("uint32_t")] uint depth, int v);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* avifCodecName(avifCodecChoice choice, [NativeTypeName("avifCodecFlags")] uint requiredFlags);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifCodecChoice avifCodecChoiceFromName([NativeTypeName("const char *")] sbyte* name);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifIO* avifIOCreateMemoryReader([NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifIO* avifIOCreateFileReader([NativeTypeName("const char *")] sbyte* filename);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifIODestroy(avifIO* io);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* avifProgressiveStateToString(avifProgressiveState progressiveState);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifDecoder* avifDecoderCreate();

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifDecoderDestroy(avifDecoder* decoder);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderRead(avifDecoder* decoder, avifImage* image);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderReadMemory(avifDecoder* decoder, avifImage* image, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderReadFile(avifDecoder* decoder, avifImage* image, [NativeTypeName("const char *")] sbyte* filename);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderSetSource(avifDecoder* decoder, avifDecoderSource source);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifDecoderSetIO(avifDecoder* decoder, avifIO* io);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderSetIOMemory(avifDecoder* decoder, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderSetIOFile(avifDecoder* decoder, [NativeTypeName("const char *")] sbyte* filename);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderParse(avifDecoder* decoder);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderNextImage(avifDecoder* decoder);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderNthImage(avifDecoder* decoder, [NativeTypeName("uint32_t")] uint frameIndex);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderReset(avifDecoder* decoder);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifDecoderIsKeyframe([NativeTypeName("const avifDecoder *")] avifDecoder* decoder, [NativeTypeName("uint32_t")] uint frameIndex);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint avifDecoderNearestKeyframe([NativeTypeName("const avifDecoder *")] avifDecoder* decoder, [NativeTypeName("uint32_t")] uint frameIndex);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderNthImageTiming([NativeTypeName("const avifDecoder *")] avifDecoder* decoder, [NativeTypeName("uint32_t")] uint frameIndex, avifImageTiming* outTiming);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint avifDecoderDecodedRowCount([NativeTypeName("const avifDecoder *")] avifDecoder* decoder);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifDecoderNthImageMaxExtent([NativeTypeName("const avifDecoder *")] avifDecoder* decoder, [NativeTypeName("uint32_t")] uint frameIndex, avifExtent* outExtent);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifEncoder* avifEncoderCreate();

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifEncoderWrite(avifEncoder* encoder, [NativeTypeName("const avifImage *")] avifImage* image, avifRWData* output);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void avifEncoderDestroy(avifEncoder* encoder);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifEncoderAddImage(avifEncoder* encoder, [NativeTypeName("const avifImage *")] avifImage* image, [NativeTypeName("uint64_t")] ulong durationInTimescales, [NativeTypeName("avifAddImageFlags")] uint addImageFlags);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifEncoderAddImageGrid(avifEncoder* encoder, [NativeTypeName("uint32_t")] uint gridCols, [NativeTypeName("uint32_t")] uint gridRows, [NativeTypeName("const avifImage *const *")] avifImage** cellImages, [NativeTypeName("avifAddImageFlags")] uint addImageFlags);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifEncoderFinish(avifEncoder* encoder, avifRWData* output);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifEncoderSetCodecSpecificOption(avifEncoder* encoder, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint avifEncoderGetGainMapSizeBytes(avifEncoder* encoder);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifImageUsesU16([NativeTypeName("const avifImage *")] avifImage* image);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifImageIsOpaque([NativeTypeName("const avifImage *")] avifImage* image);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint8_t *")]
    public static extern byte* avifImagePlane([NativeTypeName("const avifImage *")] avifImage* image, int channel);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint avifImagePlaneRowBytes([NativeTypeName("const avifImage *")] avifImage* image, int channel);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint avifImagePlaneWidth([NativeTypeName("const avifImage *")] avifImage* image, int channel);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint avifImagePlaneHeight([NativeTypeName("const avifImage *")] avifImage* image, int channel);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("avifBool")]
    public static extern int avifPeekCompatibleFileType([NativeTypeName("const avifROData *")] avifROData* input);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageApplyGainMap([NativeTypeName("const avifImage *")] avifImage* baseImage, [NativeTypeName("const avifGainMap *")] avifGainMap* gainMap, float hdrHeadroom, [NativeTypeName("avifColorPrimaries")] ushort outputColorPrimaries, [NativeTypeName("avifTransferCharacteristics")] ushort outputTransferCharacteristics, avifRGBImage* toneMappedImage, avifContentLightLevelInformationBox* clli, avifDiagnostics* diag);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifRGBImageApplyGainMap([NativeTypeName("const avifRGBImage *")] avifRGBImage* baseImage, [NativeTypeName("avifColorPrimaries")] ushort baseColorPrimaries, [NativeTypeName("avifTransferCharacteristics")] ushort baseTransferCharacteristics, [NativeTypeName("const avifGainMap *")] avifGainMap* gainMap, float hdrHeadroom, [NativeTypeName("avifColorPrimaries")] ushort outputColorPrimaries, [NativeTypeName("avifTransferCharacteristics")] ushort outputTransferCharacteristics, avifRGBImage* toneMappedImage, avifContentLightLevelInformationBox* clli, avifDiagnostics* diag);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifRGBImageComputeGainMap([NativeTypeName("const avifRGBImage *")] avifRGBImage* baseRgbImage, [NativeTypeName("avifColorPrimaries")] ushort baseColorPrimaries, [NativeTypeName("avifTransferCharacteristics")] ushort baseTransferCharacteristics, [NativeTypeName("const avifRGBImage *")] avifRGBImage* altRgbImage, [NativeTypeName("avifColorPrimaries")] ushort altColorPrimaries, [NativeTypeName("avifTransferCharacteristics")] ushort altTransferCharacteristics, avifGainMap* gainMap, avifDiagnostics* diag);

    [DllImport("avif", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern avifResult avifImageComputeGainMap([NativeTypeName("const avifImage *")] avifImage* baseImage, [NativeTypeName("const avifImage *")] avifImage* altImage, avifGainMap* gainMap, avifDiagnostics* diag);
}
