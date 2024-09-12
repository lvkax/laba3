using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassPhone
{
    public class Class1
    {
        public string Name;
        public string Model;
        public string Cost;
        public string ReleaseYear;
        public int YearOfPurchase;
        public string BatteryCapacity;
        public bool Has3Cameras;
        public bool HasWirelessCharging;

        public double GaranteEndingYear
        {
            get { return getGaranteEndingYear(); }

        }
        public double getGaranteEndingYear()
        {
            if (Name == "iPhone") return YearOfPurchase + 1;
            else if (Name == "Samsung") return YearOfPurchase + 2;
            else return YearOfPurchase + 3;
        }
    }
}