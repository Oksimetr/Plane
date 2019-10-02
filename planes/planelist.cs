using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planes
{
    sealed class Planelist : List<Plane>
    {
        public Planelist()
        {
            Add(new Plane(7004, 1, 0.25, "UTAir", new TimeSpan(0, 0, 40)));
            Add(new Plane(7001, 3, 0.20, "UTAir", new TimeSpan(0, 0, 10)));
            Add(new Plane(7002, 5, 0.50, "KrasAir", new TimeSpan(0, 0, 37)));
            Add(new Plane(7000, 6, 0.15, "AirAsia", new TimeSpan(0, 0, 28)));
        }
        public IEnumerable<string> GetFirmList()
        {
            foreach (Plane p in this)
            {
                yield return p.Firm;
            }
        }
        public IEnumerable<Plane> GetListByFirm(string firm)
        {
            foreach (Plane p in this)
            {
                if (p.Firm == firm)
                    yield return p;
            }
        }
    }
}
