﻿using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Displays;
using Meadow.Foundation.Graphics;
using Meadow.Hardware;
using Meadow.Units;
using System.Threading.Tasks;

namespace Displays.Tft.Ili9488_Sample
{
    public class MeadowApp : App<F7FeatherV2>
    {
        //<!=SNIP=>

        MicroGraphics graphics;

        public override Task Initialize()
        {
            Resolver.Log.Info("Initializing ...");

            var config = new SpiClockConfiguration(new Frequency(12000, Frequency.UnitType.Kilohertz), SpiClockConfiguration.Mode.Mode0);
            var spiBus = Device.CreateSpiBus(Device.Pins.SCK, Device.Pins.MOSI, Device.Pins.MISO, config);

            Resolver.Log.Info("Create display driver instance");

            var display = new Ili9488
            (
                spiBus: spiBus,
                chipSelectPin: Device.Pins.D02,
                dcPin: Device.Pins.D00,
                resetPin: Device.Pins.D01
            );

            graphics = new MicroGraphics(display)
            {
                IgnoreOutOfBoundsPixels = true,
                CurrentFont = new Font8x8()
            };

            return base.Initialize();
        }

        public override Task Run()
        {
            Resolver.Log.Info("Run");

            graphics.Clear();

            graphics.DrawTriangle(10, 10, 50, 50, 10, 50, Meadow.Foundation.Color.Red);
            graphics.DrawRectangle(20, 15, 40, 20, Meadow.Foundation.Color.Yellow, false);
            graphics.DrawCircle(50, 50, 40, Meadow.Foundation.Color.Blue, false);
            graphics.DrawText(5, 5, "Meadow F7");

            graphics.Show();

            return base.Run();
        }

        //<!=SNOP=>
    }
}