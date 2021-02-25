using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace ECSLegacy.Test.Unit
{
    public class Tests
    {
        private ECS uut;
        FakeTempSensor _fakeTempSensor;
        FakeHeater _fakeHeater;

        [SetUp]
        public void Setup()
        {
            _fakeTempSensor = new FakeTempSensor();
            _fakeHeater = new FakeHeater();
            uut = new ECS(20, _fakeTempSensor,_fakeHeater);

            //uut = new ECS(20, new FakeTempSensor(), new FakeHeater());
        }

        [TestCase(24)]
        [TestCase(23)]
        [TestCase(22)]
        public void Regulate_TempOverThreshold_HeaterOff(int thr)
        {
            //Arrange 

            //Tester metoden regulate at heateren turner off, når tærskelværdien ligger under den retunerede Fake-temperaturværdi på 24
            //Ønsker at der skal være koldere

            //Act

            uut.SetThreshold(thr);
            uut.Regulate();

            string state = "Heater Off";
            
            //Assert

            Assert.That(_fakeHeater.state, Is.EqualTo(state));

        }

        [TestCase(25)]
        [TestCase(26)]
        [TestCase(27)]
        public void Regulate_TempunderThreshold_HeaterOn(int thr)
        {
            //Arrange 

            //Tester metoden regulate at heateren turner on, når tærskelværdien ligger over den retunerede Fake-temperaturværdi på 24
            //Ønsker at der skal være varmere

            //Act

            uut.SetThreshold(thr);
            uut.Regulate();

            string state = "Heater On";

            //Assert

            Assert.That(_fakeHeater.state, Is.EqualTo(state));

        }

    }

    public class FakeTempSensor : ITempSensor
    {
        
        public int GetTemp()
        {
            return 24;
        }

        public bool RunSelfTest()
        {
            throw new System.NotImplementedException();
        }
    }

    public class FakeHeater : IHeater
    {
        public string state = "";
        public void TurnOn()
        {
            state = "Heater On";
        }

        public void TurnOff()
        {
            state = "Heater Off";
        }

        public bool RunSelfTest()
        {
            throw new System.NotImplementedException();
        }
    }

}