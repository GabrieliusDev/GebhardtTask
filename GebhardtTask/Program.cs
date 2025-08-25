using GebhardtTask.Models;
using GebhardtTask.Services.IO;
using GebhardtTask.Services.Reports;
using GebhardtTask.Services.Simulations;
using GebhardtTask.Services.Strategies;

public class Program
{
    public static void Main(string[] args)
    {
        DoJobInterviewScenarios();
    }

    public static void DoJobInterviewScenarios()
    {
        List<(Elevator, IMovementStrategy)> scenarios = new List<(Elevator, IMovementStrategy)>
        {
            ( new Elevator(2, [1, 3, 6, 10], [7, 9, 8]), new FIFOStrategy() ),
            ( new Elevator(2, [1, 3, 6, 10], [7, 9, 8]), new MergeAndSplitStrategy() )
        };

        ISimulationService simulator = new SimpleSimulator();
        ReportComposer reportComposer = new ReportComposer();
        IOutput consoleOutput = new ConsoleOutput();

        foreach (var (elevator, movementStrategy) in scenarios)
        {
            consoleOutput.PrintSeparator();
            var optimalRoute = movementStrategy.CalculateOptimalRoute(elevator.CurrentFloor, elevator.ElevatorCallsFromFloors, elevator.ElevatorCallsInsideElevator);
            var metrics = simulator.RunSimulation(optimalRoute, new Time(1, 2));
            var report = reportComposer.ComposeReport(optimalRoute, metrics);
            consoleOutput.PrintReport(report);
        }
    }

    public static void DoAnalysisScenarios()
    {
        List<(Elevator, IMovementStrategy)> scenarios = new List<(Elevator, IMovementStrategy)>
        {
            ( new Elevator(4, [10, 3, 2], [9, 1]), new MergeAndSplitStrategy() ),
            ( new Elevator(7, [10, 9], [3, 2, 1]), new MergeAndSplitStrategy() ),
            ( new Elevator(6, [10, 9], [3, 2, 1]), new MergeAndSplitStrategy() ),
            ( new Elevator(4, [7, 3], [6, 2, 1]), new MergeAndSplitStrategy() ),
            ( new Elevator(4, [9, 10], [8, 1, 2, 3]), new MergeAndSplitStrategy() ),
            ( new Elevator(4, [5, 2], [1, 6]), new MergeAndSplitStrategy() ),
            ( new Elevator(4, [10, 8, 9], [7, 2, 1]), new MergeAndSplitStrategy() )
        };
        ISimulationService simulator = new SimpleSimulator();
        ReportComposer reportComposer = new ReportComposer();
        IOutput consoleOutput = new ConsoleOutput();
        foreach (var (elevator, movementStrategy) in scenarios)
        {
            consoleOutput.PrintSeparator();
            var optimalRoute = movementStrategy.CalculateOptimalRoute(elevator.CurrentFloor, elevator.ElevatorCallsFromFloors, elevator.ElevatorCallsInsideElevator);
            var metrics = simulator.RunSimulation(optimalRoute, new Time(1, 2));
            var report = reportComposer.ComposeReport(optimalRoute, metrics);
            consoleOutput.PrintReport(report);
        }
    }
}