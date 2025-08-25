using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Models
{
    public class SimulationMetrics
    {
        public int TotalRouteTime { get; set; }
        public int TotalWaitTime { get; set; }
        public double AverageWaitTime { get; set; }
        public int DirectionChanges { get; set; }

        public SimulationMetrics(int totalRouteTime, int totalWaitTime, double averageWaitTime, int directionChanges)
        {
            TotalRouteTime = totalRouteTime;
            TotalWaitTime = totalWaitTime;
            AverageWaitTime = averageWaitTime;
            DirectionChanges = directionChanges;
        }
    }
}
