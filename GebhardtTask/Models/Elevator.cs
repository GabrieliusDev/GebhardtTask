using GebhardtTask.Services.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Models
{
    public class Elevator
    {
        public int CurrentFloor { get; set; }
        public List<int> ElevatorCallsFromFloors { get; set; }
        public List<int> ElevatorCallsInsideElevator { get; set; }

        public Elevator(int startingFloor, List<int> elevatorCallsFromFloors, List<int> elevatorCallsInsideElevator)
        {
            CurrentFloor = startingFloor;
            ElevatorCallsFromFloors = elevatorCallsFromFloors;
            ElevatorCallsInsideElevator = elevatorCallsInsideElevator;      
        }
    }
}
