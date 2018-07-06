using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{


    // frame markers
    public abstract class Sof : IMarker
    {
        private int n;

        protected Sof (int n)
        {
            N = n;
        }

        public int N { get => n; set => n = value; }

        public MarkerType GetMarkerType()
        {
            return MarkerType.SOF;
        }

        public bool IsHuffman ()
        {
            return N >= 0 && N <= 7;
        }

        public bool IsArithmetic ()
        {
            return !IsHuffman();
        }

        public bool IsNonDifferential ()
        {
            return (N >= 0 && N <= 4) || (N >= 8 && N <= 11);
        }

        public bool IsDifferential ()
        {
            return !IsNonDifferential();
        }

        public bool IsBaseline ()
        {
            return N == 0;
        }

        public bool IsJPEGExtension ()
        {
            return N == 8;
        }

        public bool IsSequential ()
        {
            return N == 1 || N == 5 | N == 9 || n == 13;
        }

        public bool IsProgressive ()
        {
            return N == 2 || N == 6 | N == 10 || n == 14;
        }

        public bool IsLossless ()
        {
            return N == 3 || N == 7 | N == 11 || n == 15;
        }
    }

    public class SOFn : Sof
    {
        public SOFn (byte[] buf, int n) : base (n)
        {

        }
    }
}
