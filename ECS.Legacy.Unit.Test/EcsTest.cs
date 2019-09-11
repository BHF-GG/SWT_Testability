using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.classes;

namespace ECS.Legacy.Unit.Test
{
    public class EcsTest
    {
        private ECS uut;

        [SetUp]
        public void Setup()
        {
            uut = new ECS(10,new FakeTempSensor(), new FakeHeater());
        }
    }
}
