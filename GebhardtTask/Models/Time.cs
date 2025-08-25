using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Models
{
    public class Time
    {
        public double FloorChangeTime { get; set; }
        public double FloorStopTime { get; set; }

        public Time(double floorChangeTime, double floorStopTime)
        {
            FloorChangeTime = floorChangeTime;
            FloorStopTime = floorStopTime;
        }
    }
}
