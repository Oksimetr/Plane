using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planes
{
    delegate void LandPlan(Planelist list);

    sealed class Supervisor
    {
        public string Firm { set; get; } = "None";
        private airport airPort = new airport();

        public void LandPlaneByNumber(Planelist list)
        {
            list.Sort(delegate (Plane x, Plane y)
            {
                if (x.Number > y.Number) return 1;
                else return -1;
            });
            foreach (Plane p in list)
                if (airPort.HasFreeStrip && p.Status == PlaneStatus.Fly)
                {
                    p.StartLanding(airPort.GetFreeStrip());
                }
        }
        public void LandPlaneByFuel(Planelist list)
        {
            list.Sort(delegate (Plane x, Plane y)
            {
                if (x.Fuel > y.Fuel) return 1;
                else return -1;
            });
            foreach (Plane p in list)
                if (airPort.HasFreeStrip && p.Status == PlaneStatus.Fly)
                {
                    p.StartLanding(airPort.GetFreeStrip());
                }
        }
        public void LandPlaneByFirm(Planelist list)
        {
            foreach (Plane p in list.GetListByFirm(Firm))
                if (airPort.HasFreeStrip && p.Status == PlaneStatus.Fly)
                {
                    p.StartLanding(airPort.GetFreeStrip());
                }
        }
    }
}
