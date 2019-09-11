using System;
using System.Collections.Generic;
using System.Text;

namespace ECS_H
{
    interface IHeater
    {
        void TurnOn();
        void TurnOff();
        bool RunSelfTest();
    }
}
