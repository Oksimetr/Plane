using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planes
{
    enum PlaneStatus { Fly, Landing, Crashed, Landed }

    sealed class Plane : ICloneable
    {
        private double fuel = 0;
        private double fuelspeed = 0;
        private string firm = "";
        private int number = 0;
        private TimeSpan timeforland;
        private PlaneStatus status = PlaneStatus.Fly;

        private strip LandingStrip { get; set; } = null;

        public double Fuel { get { return fuel; } }
        public string Firm { get { return firm; } }
        public int Number { get { return number; } }


        public PlaneStatus Status { get { return status; } } 
        public LogMessage OnMessage { get; set; }

        public Plane(int number, double fuel, double fuelspeed, string firm, TimeSpan timeforland)
        {
            this.number = number;
            this.fuel = fuel;
            this.fuelspeed = fuelspeed;
            this.firm = firm;
            this.timeforland = timeforland;
        }
        public object Clone()
        {
            return new Plane(number, fuel, fuelspeed, firm, timeforland);
        }

        public ListViewItem Item
        {
            get
            {
                ListViewItem newitem = new ListViewItem(number.ToString());
                newitem.SubItems.Add(fuel.ToString());
                newitem.SubItems.Add(fuelspeed.ToString());
                newitem.SubItems.Add(firm);
                newitem.SubItems.Add(timeforland.ToString(@"dd\.hh\:mm\:ss"));
                newitem.SubItems.Add(Status.ToString());
                return newitem;
            }
        }
        public void TimeTick(int second)
        {
            if (Status == PlaneStatus.Fly)
                fuel = fuel - fuelspeed * second;

            if (Status != PlaneStatus.Crashed && fuel <= 0)
            {
                status = PlaneStatus.Crashed;
                OnMessage(string.Format("Самолет борт.№ {0} компании: {1} разбился", number, firm));
            }
            if (Status == PlaneStatus.Landing)
            {
                timeforland -= new TimeSpan(0, 0, second);
                if (timeforland.Ticks <= 0)
                    FinishLanding();
            }
        }
        public void StartLanding(strip landingStrip)
        {
            this.LandingStrip = landingStrip;
            landingStrip.OccupateStrip();
            status = PlaneStatus.Landing;
            OnMessage(string.Format("Самолет борт.№ {0} компании: {1} приступил к посадке на: {2}",
                                    number, firm, landingStrip.Name));
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", number,fuel, fuelspeed, firm,timeforland);
        }
        private void FinishLanding()
        {
            status = PlaneStatus.Landed;
            OnMessage(string.Format("Самолет борт.№ {0} компании: {1} завершил посадку на: {2}",
                                    number, firm, LandingStrip.Name));
            LandingStrip.FreeStrip();
        }

    }
}
