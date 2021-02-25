using System;
using ECSLegacy;

namespace ECSLegacyNew
{
    class Program
    {
        static void Main(string[] args)
        {
            ITempSensor tempSensor = new TempSensor();
            IHeater heater = new Heater();
            //Tester
            var ecs = new ECS(28, tempSensor, heater);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();

            ecs.SetThreshold(26);

            ecs.Regulate();
        }
    }
}
