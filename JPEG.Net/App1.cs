using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public static class App1
    {

        public class Exif : IMarker
        {
            bool littleEndian;
            ushort tiffId;
            uint firstIFDOffset;
            int length;

            Ifd ifd0;

            public Exif (byte[] buf)
            {
                Length = buf.Length;

                byte[] header = new byte[8];
                Array.Copy(buf, 0, header, 0, 8);

                char c1 = Convert.ToChar(header[0]);
                char c2 = Convert.ToChar(header[1]);
                if (c1 == 'I' && c2 == 'I')
                {
                    LittleEndian = true;
                }
                else if (c1 == 'M' && c2 == 'M')
                {
                    LittleEndian = false;
                }
                else throw new Exception($"Poorly formed header, Unknown endian format: {c1} {c2}");

                byte[] magicNumber = new byte[2] {
                    header[2],
                    header[3]
                };
                
                if (LittleEndian != BitConverter.IsLittleEndian)
                {
                    Array.Reverse(magicNumber);
                }

                TiffId = BitConverter.ToUInt16(magicNumber, 0);

                if (TiffId != 42)
                {
                    throw new Exception($"Poorly formed header, Invalid TIFF ID: {TiffId}");
                }

                byte[] offset = new byte[4]
                {
                    header[4],
                    header[5],
                    header[6],
                    header[7]
                };

                if (LittleEndian != BitConverter.IsLittleEndian)
                {
                    Array.Reverse(offset);
                }

                FirstIFDOffset = BitConverter.ToUInt32(offset, 0);

                ifd0 = new Ifd(buf, FirstIFDOffset, LittleEndian);
            }

            

            public bool LittleEndian { get => littleEndian; set => littleEndian = value; }
            public ushort TiffId { get => tiffId; set => tiffId = value; }
            public uint FirstIFDOffset { get => firstIFDOffset; set => firstIFDOffset = value; }
            public int Length { get => length; set => length = value; }
            public Ifd Ifd0 { get => ifd0; set => ifd0 = value; }

            public MarkerType GetMarkerType()
            {
                return MarkerType.EXIF;
            }
        }
        public class XMP : IMarker
        {
            private int length;

            public XMP(byte[] buf)
            {
                length = buf.Length;
            }


            public MarkerType GetMarkerType()
            {
                return MarkerType.XMP;
            }
        }

        public static IMarker Parse(byte[] segmentBuffer)
        {
            int segmentLength = segmentBuffer.Length;
            byte[] exif = new byte[6];
            Array.Copy(segmentBuffer, 0, exif, 0, 6);
            string s = ASCIIEncoding.ASCII.GetString(exif);
            if (s != "Exif\0\0")
            {
                byte[] xmp = new byte[29];
                Array.Copy(segmentBuffer, 0, xmp, 0, 29);
                s = ASCIIEncoding.ASCII.GetString(xmp);

                if (s == "http://ns.adobe.com/xap/1.0/\0")
                {
                    byte[] bufx = new byte[segmentLength - 29];
                    Array.Copy(segmentBuffer, 29, bufx, 0, segmentLength - 29);
                    return new XMP(bufx);
                }
                else throw new Exception($"Parsing error - unknown APP1 format {s}");
                
            }

            byte[] buf = new byte[segmentLength - 6];
            Array.Copy(segmentBuffer, 6, buf, 0, segmentLength - 6);
            return new Exif(buf);

           
        }
    }
}
