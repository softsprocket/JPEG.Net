using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public class Appn : IApp
    {
        int n;
        byte[] buffer;

        public Appn (byte[] buff, int n)
        {
            N = n;
            Buffer = buff;
        }

        public int N { get => n; set => n = value; }
        public byte[] Buffer { get => buffer; set => buffer = value; }

        public AppType GetAppType()
        {
            return AppType.APPn;
        }
    }
}
