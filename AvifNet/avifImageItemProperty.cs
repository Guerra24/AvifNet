using System.Runtime.CompilerServices;

namespace AvifNet;

public partial struct avifImageItemProperty
{
    [NativeTypeName("uint8_t[4]")]
    public _boxtype_e__FixedBuffer boxtype;

    [NativeTypeName("uint8_t[16]")]
    public _usertype_e__FixedBuffer usertype;

    public avifRWData boxPayload;

    [InlineArray(4)]
    public partial struct _boxtype_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _usertype_e__FixedBuffer
    {
        public byte e0;
    }
}
