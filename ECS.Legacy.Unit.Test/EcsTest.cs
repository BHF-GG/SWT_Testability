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
            uut = new ECS(5,new FakeTempSensor(), new FakeHeater());
        }

        [Test]
        public void TestGetCurTemp_ResultOK()
        {
            Assert.AreEqual(uut.GetCurTemp(),10);
        }

        [Test]
        public void TestGetTresHold_ResultOK()
        {
            Assert.AreEqual(uut.GetThreshold(), 5);
        }

        [Test]
        public void TestSetTresHold_ResultOK()
        {
            uut.SetThreshold(4);
            Assert.That(uut.GetThreshold(), Is.EqualTo(4));
        }

        [Test]
        public void RunSelftest_ResultOK()
        {
            Assert.That(uut.RunSelfTest, Is.EqualTo(true));
        }

    }
}
