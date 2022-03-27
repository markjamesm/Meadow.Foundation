﻿using Meadow.Foundation.Sensors.Base;
using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow.Foundation.Sensors.Light
{
    /// <summary>
    /// Represents a Temt6000 light sensor
    /// </summary>
    public class Temt6000 : AnalogObservableBase
    {
        /// <summary>
        /// Creates a new Temt6000 driver
        /// </summary>
        /// <param name="pin">AnalogChannel connected to the sensor.</param>
        public Temt6000(IAnalogInputController device, IPin pin, int sampleCount = 5, TimeSpan? sampleInterval = null, Voltage? voltage = null)
            : this(device.CreateAnalogInputPort(pin, sampleCount, sampleInterval ?? TimeSpan.FromMilliseconds(40), voltage ?? new Voltage(3.3)))
        { }

        /// <summary>
        /// Creates a new Temt6000 driver
        /// </summary>
        /// <param name="port"></param>
        public Temt6000(IAnalogInputPort port) : base(port) 
        { }
    }
}