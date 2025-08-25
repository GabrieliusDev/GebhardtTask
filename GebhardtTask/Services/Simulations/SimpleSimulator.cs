using GebhardtTask.Enums;
using GebhardtTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GebhardtTask.Services.Simulations
{
    public class SimpleSimulator : ISimulationService
    {
        public SimulationMetrics RunSimulation(Route route, Time time)
        {
            int totalRouteTime = 0;
            int totalWaitTime = 0;
            double averageWaitTime = 0;
            int directionChanges = 0;

            var currentFloor = -1;
            var currentDirection = Directions.None;
            foreach (var stop in route.Stops)
            {
                if(currentFloor == -1)
                {
                    currentFloor = stop;
                }
                else
                {
                    var newDirection = currentFloor - stop > 0 ? Directions.Up : Directions.Down;

                    if (currentDirection != Directions.None && newDirection != currentDirection)
                        directionChanges++;

                    currentDirection = newDirection;
                    totalRouteTime += (int)(Math.Abs(currentFloor - stop) * time.FloorChangeTime + time.FloorStopTime);
                    totalWaitTime += totalRouteTime;

                    currentFloor = stop;
                }
            }

            averageWaitTime = route.Stops.Count > 0 ? (double)totalWaitTime / (route.Stops.Count - 1) : 0;

            return new SimulationMetrics(totalRouteTime, totalWaitTime, averageWaitTime, directionChanges);
        }
    }
}
