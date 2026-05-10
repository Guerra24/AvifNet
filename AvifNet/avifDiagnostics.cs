using System.Runtime.CompilerServices;

namespace AvifNet;

public partial struct avifDiagnostics
{
    [NativeTypeName("char[256]")]
    public _error_e__FixedBuffer error;

    [InlineArray(256)]
    public partial struct _error_e__FixedBuffer
    {
        public sbyte e0;
    }
}
