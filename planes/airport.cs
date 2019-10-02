using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planes
{
    sealed class airport
    {
        List<strip> strips = new List<strip>();

        public airport()
        {
            strips.Add(new strip(1));
            strips.Add(new strip(2));
            strips.Add(new strip(3));
        }
        public bool HasFreeStrip
        {
            get
            {
                foreach (strip s in strips)
                    if (!s.isBusy) return true;
                return false;
            }
        }
        public strip GetFreeStrip()
        {
            foreach (strip s in strips)
                if (!s.isBusy)
                {
                    s.OccupateStrip();
                    return s;
                }
            return null;
        }

    }
}
