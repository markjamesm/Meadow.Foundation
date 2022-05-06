﻿using System;
using System.Threading;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.ICs.IOExpanders;

namespace ICs.IOExpanders.Ds3502_Sample
{
    public class MeadowApp : App<F7FeatherV2, MeadowApp>
    {
        //<!=SNIP=>

        protected Ds3502 ds3502;

        public MeadowApp()
        {
            Console.WriteLine("Initialize...");

            ds3502 = new Ds3502(Device.CreateI2cBus(Ds3502.DefaultBusSpeed));

            for (byte i = 0; i < 127; i++)
            {
                ds3502.SetWiper(i);
                Console.WriteLine($"wiper {ds3502.GetWiper()}");

                Thread.Sleep(1000);
            }
        }

        //<!=SNOP=>
    }
}