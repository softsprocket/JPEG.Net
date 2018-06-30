using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{

    public enum AppType
    {
        EXIF,
        XMP,
        APPn,
        JFIF,
        JFXX
    }

    public interface IApp
    {
        AppType GetAppType();
    }
}
