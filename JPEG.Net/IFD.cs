using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public class IFD
    {
        uint tag;
        uint type;
        uint count;
        uint offset;

        public uint Tag { get => tag; set => tag = value; }
        public uint Type { get => type; set => type = value; }
        public uint Count { get => count; set => count = value; }
        public uint Offset { get => offset; set => offset = value; }
    }
}
