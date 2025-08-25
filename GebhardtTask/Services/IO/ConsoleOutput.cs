using GebhardtTask.Models;
using GebhardtTask.Services.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Services.IO
{
    public class ConsoleOutput : IOutput
    {
        public void PrintReport(Report report)
        {
            Console.WriteLine("1) Aukštų planas: " + string.Join(" -> ", report.Route.Stops));
            Console.WriteLine("2) Kelionės trukmė (s): " + report.TotalRouteTime);
            Console.WriteLine("3) Bendras laukimas (s): " + report.TotalWaitTime.ToString());
            Console.WriteLine("   Vidutinis laukimas (s): " + Math.Round(report.AverageWaitTime, 2).ToString());
            Console.WriteLine("4) Krypties keitimai: " + report.DirectionChanges.ToString());
        }

        public void PrintSeparator()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
