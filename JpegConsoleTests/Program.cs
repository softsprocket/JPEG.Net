using JPEG.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Greg\Pictures\file000325161223.jpg";
            //string path = @"E:\Development\vs2017\RotationGdiTest\Debug\D500\DSC_0001.JPG";

            if (args.Length > 0)
            {
                path = args[0];
            }

            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                byte[] buf2 = new byte[2];
                fileStream.Read(buf2, 0, 2);
                if (buf2[0] != 0xFF && buf2[1] != 0xD8)
                {
                    Console.WriteLine("File not a JPEG");
                    goto done;
                }

                fileStream.Read(buf2,  0, 2);
                while (!Jpeg.Definitions.SOS(buf2) && !Jpeg.Definitions.SOI(buf2))
                {
                    
                    byte[] lenbuf = new byte[2];
                    fileStream.Read(lenbuf, 0, 2);
                    Array.Reverse(lenbuf);
                    ushort segmentLength = BitConverter.ToUInt16(lenbuf, 0);
                    int len = (int)segmentLength - 2;
                    Console.WriteLine($"Reading {len} {BitConverter.ToString(lenbuf)} {BitConverter.ToString(buf2)} ");
                    if (len <= 0)
                    {
                        goto done;
                    }


                    byte[] buf = new byte[len];
                    fileStream.Read(buf, 0, len);
                    try
                    {
                        
                        if (Jpeg.Definitions.APP0(buf2))
                        {
                            IMarker app0 = App0.Parse(buf);
                            if (app0.GetMarkerType() == MarkerType.JFIF)
                            {
                                App0.Jfif jfif = (App0.Jfif)app0;
                                Console.WriteLine($"Jfif {jfif.GetVersion()}");
                                switch (jfif.DensityUnit)
                                {
                                    case App0.Jfif.XYDensityUnit.AspectRatio:
                                        Console.WriteLine("XYDensityUnit AspectRatio");
                                        break;
                                    case App0.Jfif.XYDensityUnit.DotsPerInch:
                                        Console.WriteLine("XYDensityUnit DotsPerInch");
                                        break;
                                    case App0.Jfif.XYDensityUnit.DotsPerCm:
                                        Console.WriteLine("XYDensityUnit DOtsPerCm");
                                        break;
                                }

                                Console.WriteLine($"XDensity {jfif.XDensity}, YDensity {jfif.YDensity}");
                                Console.WriteLine($"Thumbnail X {jfif.XThumbnailCount}, Thumbnail Y {jfif.YThumbnailCount}");
                            }
                            else if (app0.GetMarkerType() == MarkerType.JFXX)
                            {
                                App0.Jfxx jfxx = (App0.Jfxx)app0;
                                Console.WriteLine("Jfxx");
                            }
                            else
                            {
                                Console.WriteLine("APP0");
                            }

                        }
                        else if (Jpeg.Definitions.APP1(buf2))
                        {
                            IMarker app = App1.Parse(buf);

                            if (app.GetMarkerType() == MarkerType.EXIF)
                            {
                                App1.Exif exif = (App1.Exif)app;
                                Console.WriteLine($"Exif {exif.TiffId} {exif.FirstIFDOffset} {exif.Length}");
                                Ifd ifd0 = exif.Ifd0;
                                Console.WriteLine($"IFD0 tag count {ifd0.FieldInteroperabiltyCount}");
                                Console.WriteLine($"Next IFD {ifd0.OffsetToNextIfd}");
                                for (int i = 0; i < ifd0.FieldInteroperabilties.Length; ++i)
                                {
                                    Console.WriteLine($"{ifd0.FieldInteroperabilties[i].TypeValue.TypeToString()} {ifd0.FieldInteroperabilties[i].Tag}");
                                    Console.WriteLine(ifd0.FieldInteroperabilties[i]);

                                    if (ifd0.FieldInteroperabilties[i].ExifIfd)
                                    {
                                        Ifd exifIfd = ifd0.FieldInteroperabilties[i].Exif;
                                        for (int j = 0; j < exifIfd.FieldInteroperabilties.Length; ++j)
                                        {
                                            Console.WriteLine($"{exifIfd.FieldInteroperabilties[j].TypeValue.TypeToString()} {exifIfd.FieldInteroperabilties[j].Tag}");
                                            Console.WriteLine(exifIfd.FieldInteroperabilties[j]);
                                        }
                                    }


                                    if (ifd0.FieldInteroperabilties[i].InteroperabilityIfd)
                                    {
                                        Ifd interoperabilityIfd = ifd0.FieldInteroperabilties[i].Interoperability;
                                        for (int j = 0; j < interoperabilityIfd.FieldInteroperabilties.Length; ++j)
                                        {
                                            Console.WriteLine($"{interoperabilityIfd.FieldInteroperabilties[j].TypeValue.TypeToString()} {interoperabilityIfd.FieldInteroperabilties[j].Tag}");
                                            Console.WriteLine(interoperabilityIfd.FieldInteroperabilties[j]);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                App1.XMP xmp = (App1.XMP)app;
                                Console.WriteLine("XMP");
                                Console.WriteLine (xmp.RawXml);
                            }
                        }
                        else if (Jpeg.Definitions.APPn(buf2))
                        {
                            Appn appn = new Appn(buf, buf2[1] & 0x0F);
                            Console.WriteLine($"Appn {appn.N}");
                        }
                        else if (Jpeg.Definitions.DQT(buf2))
                        {
                            Console.WriteLine($"DQT");
                        }
                        else if (Jpeg.Definitions.SOFn(buf2))
                        {
                            SOFn sofn = new SOFn(buf, buf2[1] & 0x0F);
                            Console.WriteLine($"SOFn {sofn.N}");
                        }
                        else if (Jpeg.Definitions.DRI(buf2))
                        {
                            Console.WriteLine("DRI");
                        }
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    
                    fileStream.Read(buf2,  0, 2);
                }

            }  
done:
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Complete. Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
