using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public static class App0
    {
        public class Jfif : IApp
        {
            public Jfif (byte[] buf)
            {

            }

            public AppType GetAppType()
            {
                return AppType.JFIF;
            }
        }

        public class Jfxx : IApp
        {
            public Jfxx(byte[] buf)
            {

            }

            public AppType GetAppType()
            {
                return AppType.JFXX;
            }
        }

        public static IApp Parse (byte[] buf)
        {
            byte[] identifier = new byte[5];
            Array.Copy(buf, 0, identifier, 0, 5);
            
            string s = ASCIIEncoding.ASCII.GetString(identifier);

            IApp app = null;
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
