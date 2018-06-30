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
                        if (Jpeg.Definitions.APP1(buf2))
                        {
                            IApp app = App1.Parse(buf);

                            if (app.GetAppType() == AppType.EXIF)
                            {
                                App1.Exif exif = (App1.Exif)app;
                                Console.WriteLine($"Exif {exif.TiffId} {exif.FirstIFDOffset} {exif.Length}");
                            }
                            else
                            {
                                App1.XMP xmp = (App1.XMP)app;
                                Console.WriteLine("XMP");
                            }
                        }
                        else if (Jpeg.Definitions.APP0(buf2))
                        {
                            Console.WriteLine("APP0");
                            IApp app0 = App0.Parse(buf);
                        } 
                        else if (Jpeg.Definitions.APPn(buf2))
                        {
                            Appn appn = new Appn(buf, buf2[1] & 0x0F);
                            Console.WriteLine($"Appn {appn.N}");
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
