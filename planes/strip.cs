using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planes
{
    sealed class strip
    {
        private const string name = "Полоса ";
        private bool isbusy = false;
        public bool isBusy { get { return isbusy; } }
        public string Name
        {
            get
            {
                return string.Format("{0}{1}", name, Number);
            }
        }
        public int Number { get; } = 0;
        public strip(int number)
        {
            Number = number;
        }
        public void FreeStrip()
        {
            isbusy = false;
        }
        public void OccupateStrip()
        {
            isbusy = true;
        }
    }
}
