using System.Runtime.InteropServices;

namespace Ryujinx.Core.OsHle.Services.Aud
{
    [StructLayout(LayoutKind.Sequential)]
    struct AudioOutData
    {
        public long NextBufferPtr;
        public long SampleBufferPtr;
        public long SampleBufferCapacity;
        public long SampleBufferSize;
        public long SampleBufferInnerOffset;
    }
}