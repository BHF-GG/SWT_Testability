using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.Interfaces;

namespace ECS.Legacy.classes
{
    class FakeHeater : IHeater
    {
        public bool On { get; set; }
        public bool Off { get; set; }

        public void TurnOn()
        {
            On = true;
            Off = false;
        }

        public void TurnOff()
        {
            On = false;
            Off = true;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}

