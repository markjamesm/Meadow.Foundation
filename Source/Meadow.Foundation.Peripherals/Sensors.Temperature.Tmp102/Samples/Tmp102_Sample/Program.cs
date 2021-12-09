﻿using System.Threading;
using Meadow;

namespace Sensors.Temperature.Tmp102_Sample
{
    class Program
    {
        static IApp app;
        public static void Main(string[] args)
        {
            // instantiate and run new meadow app
            app = new MeadowApp();

            Thread.Sleep(-1);
        }
    }
}