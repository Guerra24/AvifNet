namespace AvifNet;

public enum avifAddImageFlag
{
    AVIF_ADD_IMAGE_FLAG_NONE = 0,
    AVIF_ADD_IMAGE_FLAG_FORCE_KEYFRAME = (1 << 0),
    AVIF_ADD_IMAGE_FLAG_SINGLE = (1 << 1),
}
