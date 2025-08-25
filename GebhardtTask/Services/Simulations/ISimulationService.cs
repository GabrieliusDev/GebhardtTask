using GebhardtTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Services.Simulations
{
    public interface ISimulationService
    {
        public SimulationMetrics RunSimulation(Route route, Time time);
    }
}
