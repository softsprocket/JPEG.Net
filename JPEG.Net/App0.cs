using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public static class App0
    {
        public class Jfif : IMarker
        {
            public enum XYDensityUnit
            {
                AspectRatio,
                DotsPerInch,
                DotsPerCm
            }

            ushort versionMajor;
            ushort versionMinor;
            XYDensityUnit densityUnit;
            ushort xDensity;
            ushort yDensity;
            ushort xThumbnailCount;
            ushort yThumbnailCount;

            uint thumbnailSize;
            byte[] thumbnail;

            public Jfif (byte[] buf)
            {
                versionMajor = buf[5];
                versionMinor = buf[6];

                if (buf[7] == 0)
                {
                    densityUnit = XYDensityUnit.AspectRatio;     
                } 
                else if (buf[7] == 1)
                {
                    densityUnit = XYDensityUnit.DotsPerInch;
                }
                else if (buf[7] == 2)
                {
                    densityUnit = XYDensityUnit.DotsPerCm;
                }

                byte[] b2 = new byte[2];
                b2[0] = buf[9];
                b2[1] = buf[8];
                xDensity = BitConverter.ToUInt16(b2, 0);
                b2[0] = buf[11];
                b2[1] = buf[10];
                yDensity = BitConverter.ToUInt16(b2, 0);

                xThumbnailCount = buf[12];
                yThumbnailCount = buf[13];

                thumbnailSize = (uint)xThumbnailCount * yThumbnailCount * 3;
                if (HasThumbnail())
                {
                    thumbnail = new byte[thumbnailSize];
                    Array.Copy(buf, 14, thumbnail, 0, thumbnailSize);
                }
            }

            public ushort VersionMajor { get => versionMajor; set => versionMajor = value; }
            public ushort VersionMinor { get => versionMinor; set => versionMinor = value; }
            public XYDensityUnit DensityUnit { get => densityUnit; set => densityUnit = value; }
            public ushort XDensity { get => xDensity; set => xDensity = value; }
            public ushort YDensity { get => yDensity; set => yDensity = value; }
            public ushort XThumbnailCount { get => xThumbnailCount; set => xThumbnailCount = value; }
            public ushort YThumbnailCount { get => yThumbnailCount; set => yThumbnailCount = value; }
            public byte[] Thumbnail { get => thumbnail; set => thumbnail = value; }

            public bool HasThumbnail ()
            {
                return thumbnailSize != 0;
            }

            public string GetVersion ()
            {
                return $"{VersionMajor}.{VersionMinor}";
            }

            public MarkerType GetMarkerType()
            {
                return MarkerType.JFIF;
            }


        }

        public class Jfxx : IMarker
        {
            public Jfxx(byte[] buf)
            {

            }

            public MarkerType GetMarkerType()
            {
                return MarkerType.JFXX;
            }
        }

        public static IMarker Parse (byte[] buf)
        {
            byte[] identifier = new byte[5];
            Array.Copy(buf, 0, identifier, 0, 5);
            
            string s = ASCIIEncoding.ASCII.GetString(identifier);

            IMarker app = null;
            if (s == "JFIF\0")
            {
                app = new Jfif(buf);
            }
            else if (s == "Jfxx\0")
            {
                app = new Jfxx(buf);
            }
            else throw new Exception("Parse error - Unknown App0 type");

            return app;

        }
    }
}
