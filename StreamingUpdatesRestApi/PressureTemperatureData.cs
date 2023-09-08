﻿using OSIsoft.Data;

namespace StreamingUpdatesRestApi
{
    public class PressureTemperatureData
    {
        [SdsMember(IsKey = true)]
        public DateTime Timestamp { get; set; }

        public double Pressure { get; set; }
        public double Temperature { get; set; }
    }
}