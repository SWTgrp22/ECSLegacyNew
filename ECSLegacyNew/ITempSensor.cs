using System;
using System.Collections.Generic;
using System.Text;

namespace ECSLegacy
{
    public interface ITempSensor
    {
        public int GetTemp();

        public bool RunSelfTest();

    }
}