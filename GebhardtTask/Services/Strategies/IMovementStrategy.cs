using GebhardtTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Services.Strategies
{
    public interface IMovementStrategy
    {
        public Route CalculateOptimalRoute(int currentFloor, List<int> elevatorCallsFromFloors, List<int> elevatorCallsInsideElevator);
    }
}
