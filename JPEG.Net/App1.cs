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

        public class Exif : IApp
        {
            bool littleEndian;
            Int16 tiffId;
            Int32 firstIFDOffset;
            uint length;

            public Exif (FileStream fileStream, uint len)
            {
                Length = len;

                byte[] header = new byte[8];
                fileStream.Read(header, 0, 8);

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

                TiffId = BitConverter.ToInt16(magicNumber, 0);

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

                FirstIFDOffset = BitConverter.ToInt32(offset, 0);

            }

            public bool LittleEndian { get => littleEndian; set => littleEndian = value; }
            public short TiffId { get => tiffId; set => tiffId = value; }
            public int FirstIFDOffset { get => firstIFDOffset; set => firstIFDOffset = value; }
            public uint Length { get => length; set => length = value; }

            public AppType GetAppType()
            {
                return AppType.EXIF;
            }
        }
        public class XMP : IApp
        {
            public AppType GetAppType()
            {
                return AppType.XMP;
            }
        }

        public static IApp Parse(FileStream fileStream)
        {
            byte[] buf2 = new byte[2];
            fileStream.Read(buf2, 0, 2);
            uint exifLen = BitConverter.ToUInt16(buf2, 0);

            byte[] exif = new byte[6];
            fileStream.Read(exif, 0, 6);
            string s = ASCIIEncoding.ASCII.GetString(exif);
            if (s != "Exif\0\0")
            {
                return new XMP();       
            }


            return new Exif(fileStream, exifLen);

           
        }
    }
}
