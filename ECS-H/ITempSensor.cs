using System;
using System.Collections.Generic;
using System.Text;

namespace ECS_H
{
    interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }
}
