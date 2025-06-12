using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Switch
    {
        private readonly IDevices devices;
        public Switch (IDevices device)
        {
            devices = device;
        }

        public void Press()
        {
            devices.operate();
        }
    }
}
