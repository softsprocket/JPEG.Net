using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{

    public enum MarkerType
    {
        EXIF,
        XMP,
        APPn,
        JFIF,
        JFXX,
        DQT,
        SOF
    }

    public interface IMarker
    {
        MarkerType GetMarkerType();
    }
}
