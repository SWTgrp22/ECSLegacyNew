using System.Runtime.CompilerServices;
using NSubstitute;
using NUnit.Framework;

namespace ECSLegacy.Test.Unit
{
    public class Tests_Regular
    {
        //    private ECS uut;
        //    private FakeTempSensor _fakeTempSensor;
        //    private FakeHeater _fakeHeater;

        //    [SetUp]
        //    public void Setup()
        //    {
        //        _fakeTempSensor = new FakeTempSensor();
        //        _fakeHeater = new FakeHeater();
        //        uut = new ECS(20, _fakeTempSensor,_fakeHeater);

        //        //uut = new ECS(20, new FakeTempSensor(), new FakeHeater());
        //    }

        //    [TestCase(24)]
        //    [TestCase(23)]
        //    [TestCase(22)]
        //    public void Regulate_TempOverThreshold_HeaterOff(int thr)
        //    {
        //        //Arrange 

        //        //Tester metoden regulate at heateren turner off, når tærskelværdien ligger under den retunerede Fake-temperaturværdi på 24
        //        //Ønsker at der skal være koldere

        //        //Act

        //        uut.SetThreshold(thr);
        //        uut.Regulate();

        //        string state = "Heater Off";

        //        //Assert

        //        Assert.That(_fakeHeater.state, Is.EqualTo(state));

        //    }

        //    [TestCase(25)]
        //    [TestCase(26)]
        //    [TestCase(27)]
        //    public void Regulate_TempunderThreshold_HeaterOn(int thr)
        //    {
        //        //Arrange 

        //        //Tester metoden regulate at heateren turner on, når tærskelværdien ligger over den retunerede Fake-temperaturværdi på 24
        //        //Ønsker at der skal være varmere

        //        //Act

        //        uut.SetThreshold(thr);
        //        uut.Regulate();

        //        string state = "Heater On";

        //        //Assert

        //        Assert.That(_fakeHeater.state, Is.EqualTo(state));

        //    }

        //}

        //public class FakeTempSensor : ITempSensor
        //{

        //    public int GetTemp()
        //    {
        //        return 24;
        //    }

        //    public bool RunSelfTest()
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //}

        //public class FakeHeater : IHeater
        //{
        //    public string state = "";
        //    public void TurnOn()
        //    {
        //        state = "Heater On";
        //    }

        //    public void TurnOff()
        //    {
        //        state = "Heater Off";
        //    }

        //    public bool RunSelfTest()
        //    {
        //        throw new System.NotImplementedException();
        //    }

        //[TestCase(-35)]
        //[TestCase(23)]
        //[TestCase(200)]
        //public void SetThreshold_SetsThreshold_ThresholdIsTrue(int thr)
        //{
        //    //EP: Her er testet at threshold både kan sættes til meget høje værdier og negative heltal

        //    //Arange 

        //    //Act
        //    uut.SetThreshold(thr);


        //    //Assert
        //    Assert.That(uut.GetThreshold(), Is.EqualTo(thr));

        //}

        //[TestCase(-100)]
        //[TestCase(24)]
        //[TestCase(240)]
        //public void GetCurTemp_GetCurrentTempFromStub_ÏsEqalToInput(int temp)
        //{
        //    //EP: Her er testet at temperaturen både kan sættes til meget høje værdier og negative heltal

        //    //Arange 

        //    //Act
        //    _fakeTempSensor.GetTemp().Returns(temp);
        //    //uut.GetCurTemp();


        //    //Assert
        //    Assert.That(uut.GetCurTemp(), Is.EqualTo(temp));
        //}
    }

}