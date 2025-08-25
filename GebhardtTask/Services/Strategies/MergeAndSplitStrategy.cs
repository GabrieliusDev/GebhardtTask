using GebhardtTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Services.Strategies
{
    public class MergeAndSplitStrategy : IMovementStrategy
    {
        private struct DirectionWeight
        {
            public double Up { get; set; }
            public double Down { get; set; }
        }

        public Route CalculateOptimalRoute(int currentFloor, List<int> elevatorCallsFromFloors, List<int> elevatorCallsInsideElevator)
        {
            List<int> mergedElevatorCalls = elevatorCallsFromFloors.Concat(elevatorCallsInsideElevator).Distinct().Order().ToList();
            List<int> lowerStops = mergedElevatorCalls.Where(x => x < currentFloor).OrderDescending().ToList();
            List<int> higherStops = mergedElevatorCalls.Where(x => x > currentFloor).ToList();

            DirectionWeight directionWeight = new DirectionWeight
            {
                Up = higherStops.Count > 0 ? (double)higherStops.Count / (higherStops.LastOrDefault() - currentFloor) : 0,
                Down = lowerStops.Count > 0 ? (double)lowerStops.Count / (currentFloor - lowerStops.LastOrDefault()) : 0
            };

            List<int> optimalRoute = new List<int>();
            if (directionWeight.Up >= directionWeight.Down)
            {
                optimalRoute = [currentFloor, .. higherStops, .. lowerStops];
            }
            else
            {
                optimalRoute = [currentFloor, .. lowerStops, .. higherStops];
            }

            if (mergedElevatorCalls.Contains(currentFloor))
                return new Route([currentFloor, .. optimalRoute]); 
            else
                return new Route(optimalRoute);

        }
    }
}
