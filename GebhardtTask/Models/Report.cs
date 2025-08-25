using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Models
{
    public class Report
    {
        public Route Route { get; set; }
        public int TotalRouteTime { get; set; }
        public int TotalWaitTime { get; set; }
        public double AverageWaitTime { get; set; }
        public int DirectionChanges { get; set; }

        public Report(Route route, int totalRouteTime, int totalWaitTime, double averageWaitTime, int directionChanges)
        {
            Route = route;
            TotalRouteTime = totalRouteTime;
            TotalWaitTime = totalWaitTime;
            AverageWaitTime = averageWaitTime;
            DirectionChanges = directionChanges;
        }
    }
}
