using GebhardtTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Services.Reports
{
    public class ReportComposer
    {
        public Report ComposeReport(Route route, SimulationMetrics metrics)
        {
            return new Report(route, metrics.TotalRouteTime, metrics.TotalWaitTime, metrics.AverageWaitTime, metrics.DirectionChanges);
        }
    }
}
