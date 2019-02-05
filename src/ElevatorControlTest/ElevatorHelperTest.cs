using System;
using System.Collections.Generic;
using ElevatorControl;
using Xunit;
using System.Linq;

namespace ElevatorControlTest
{
    public class ElevatorHelperTest
    {
        private ElevatorHelper elevatorHelper;
        private Elevator elevator;
        public ElevatorHelperTest()
        {
            List<Passenger> passengers = new List<Passenger>();
            Floor elevatorPosition = new Floor(0);
            elevator = new Elevator(passengers, elevatorPosition, Direction.DOWN);
            elevatorHelper = new ElevatorHelper();
        }

        [Fact]
        public void ElevatorHelper_FindTheNearestPassenger()
        {
            elevator.Passengers.Add(new Passenger("Mike", "John", new Floor(4), null, Direction.UP));
            elevator.Passengers.Add(new Passenger("Samuel", "Doe", new Floor(5), null, Direction.DOWN));

            Floor closestPosition = elevatorHelper.FindClosestPassenger(elevator);

            Assert.Equal(new Floor(4), closestPosition);
        }

        [Fact]
        public void ElevatorHelper_FindPassengerAtDestination()
        {
            List<Passenger> passengers = new List<Passenger>();
            Floor elevatorPosition = new Floor(7);
            elevator = new Elevator(passengers, elevatorPosition, Direction.DOWN);
            elevatorHelper = new ElevatorHelper();

            elevator.Passengers.Add(new Passenger("Mike", "John", new Floor(4), new Floor(7), Direction.UP));
            elevator.Passengers.Add(new Passenger("Samuel", "Doe", new Floor(5), new Floor(8), Direction.DOWN));

            List<Passenger> passenger = elevatorHelper.FindPassengerAtDestination(elevator);

            Assert.Equal("Mike", passenger.FirstOrDefault().FirstName);
        }
    }
}
