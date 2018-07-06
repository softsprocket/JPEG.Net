using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG.Net
{
    public class Dqt : IMarker
    {
        public MarkerType GetMarkerType()
        {
            return MarkerType.DQT;
        }
    }
}
