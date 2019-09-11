using System;
using System.Collections.Generic;
using System.Text;

namespace ECS_H
{
    class TempSensor
    {
        private readonly Random _gen = new Random();
        public int GetTemp()
        {
            return _gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
