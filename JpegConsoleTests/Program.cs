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
            string path = @"D:\development\images\D500\DSC_0001.JPG";

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

                if (Jpeg.Definitions.APP1(buf2))
                {
                    IApp app = App1.Parse(fileStream);
                    App1.Exif exif = null;

                    if (app.GetAppType() == AppType.EXIF)
                    {
                        exif = (App1.Exif)app;
                    }
                    else
                    {
                        Console.WriteLine("Not APP1");
                        goto done;
                    }

                    Console.WriteLine($"{exif.TiffId} {exif.FirstIFDOffset} {exif.Length}");

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
