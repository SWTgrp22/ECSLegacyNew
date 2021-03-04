using System.Runtime.CompilerServices;
using NSubstitute;
using NUnit.Framework;

namespace ECSLegacy.Test.Unit
{
    public class Tests_NSubstitute
    {
        private ECS uut;
        ITempSensor _fakeTempSensor;
        IHeater _fakeHeater;

        [SetUp]
        public void Setup()
        {
            _fakeTempSensor = Substitute.For<ITempSensor>();
            _fakeHeater = Substitute.For<IHeater>();
            uut = new ECS(20, _fakeTempSensor,_fakeHeater);

            //uut = new ECS(20, new FakeTempSensor(), new FakeHeater());
        }

        [TestCase(24)]
        [TestCase(23)]
        [TestCase(22)]
        public void Regulate_TempOverThreshold_HeaterOff(int temp)
        {
            //Arrange 

            //Tester metoden regulate at heateren turner off, når temperaturen ligger over tærskelværdien
            //Ønsker at der skal være koldere

            //Act

            _fakeTempSensor.GetTemp().Returns(temp);
            uut.Regulate();

            //Assert
            _fakeHeater.Received(1).TurnOff();

        }

        [TestCase(19)]
        [TestCase(10)]
        [TestCase(5)]
        public void Regulate_TempunderThreshold_HeaterOn(int temp)
        {
            //Arrange 

            //Tester metoden regulate at heateren turner on, når temperaturen ligger under tærskelværdien
            //Ønsker at der skal være varmere

            //Act
            _fakeTempSensor.GetTemp().Returns(temp);
            uut.Regulate();

            //Assert
            _fakeHeater.Received(1).TurnOn();
        }

        [TestCase(false,true)]
        [TestCase(true,false)]
        [TestCase(false,false)]
        public void RunSelfTest_SubstituteFails_SelfTestFail(bool tempsensor, bool heater)
        {
            //Arrange

            //Act
            _fakeTempSensor.RunSelfTest().Returns(tempsensor);
            _fakeHeater.RunSelfTest().Returns(heater);

            //Assert
            Assert.IsFalse(uut.RunSelfTest());
        }

        [Test]
        public void RunSelfTest_SubstituteApproved_SelfTestApproved()
        {
            //Arrange

            //Act
            _fakeTempSensor.RunSelfTest().Returns(true);
            _fakeHeater.RunSelfTest().Returns(true);

            //Assert
            Assert.IsTrue(uut.RunSelfTest());
        }
    }


}