using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public partial class Jpeg
    {
        public static class Definitions
        {
            // Start Of Image
            public static bool SOI(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xD8;
            }

            // Start Of Frame(Baseline DCT)
            // Indicates that this is a baseline DCT-based JPEG, and specifies the width, height, 
            // number of components, and component subsampling
            public static bool SSOF0(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xC0;
            }

            // Start Of Frame(Progressive DCT)
            // Indicates that this is a progressive DCT-based JPEG, and specifies the width, height, 
            // number of components, and component subsampling
            public static bool SOF2(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xC2;
            }

            // Define Huffman Table(s)
            public static bool DHT(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xC4;
            }

            // Define Quantization Table(s)
            public static bool DQT(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xDB;
            }

            // Define Restart Interval
            // Specifies the interval between RSTn markers, in macroblocks.
            // This marker is followed by two bytes indicating the fixed size 
            // so it can be treated like any other variable size segment.
            public static bool DRI(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xDD;
            }

            // Start Of Scan
            // Begins a top - to - bottom scan of the image.
            // In baseline DCT JPEG images, there is generally a single scan.
            // Progressive DCT JPEG images usually contain multiple scans.
            // This marker specifies which slice of data it will contain, and is immediately followed by entropy - coded data.
            public static bool SOS(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xDA;
            }

            // Restart
            // n(n = 0..7) 
            // Inserted every r macroblocks, where r is the restart interval set by a DRI marker.
            // Not used if there was no DRI marker.The low 3 bits of the marker code cycle in value from 0 to 7.
            public static bool RSTn(byte[] b)
            {
                return b[0] == 0xFF && (b[1] >= 0xD0 && b[1] <= b[7]);
            }

            // Application - specific
            // For example, an Exif JPEG file uses an APP1 marker to store metadata, laid out in a structure based closely on TIFF.
            public static bool APPn(byte[] b)
            {
                return b[0] == 0xFF && (b[1] >= 0xE0 && b[1] <= 0xEF);
            }


            //EXIF or XMP
            public static bool APP1(byte[] b)
            {
                return APPn(b) && GetN(b[1]) == 1;
            }

            //FIF
            public static bool APP0(byte[] b)
            {
                return APPn(b) && GetN(b[1]) == 0;
            }

            // Comment
            public static bool COM(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xFE;
            }

            // End Of Image
            public static bool EOI(byte[] b)
            {
                return b[0] == 0xFF && b[1] == 0xD9;
            }

            public static int GetN (byte b)
            {
                return b & 0x0F;
            }
        }


    }
}
