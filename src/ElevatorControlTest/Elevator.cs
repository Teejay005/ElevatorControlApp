using System;
using System.Collections.Generic;
using ElevatorControl;
using Xunit;
using System.Linq;

namespace ElevatorControlTest
{
    public class ElevatorControl
    {
        private readonly ElevatorHelper elevatorHelper;
        public ElevatorControl()
        {
            elevatorHelper = new ElevatorHelper();
        }

        [Fact]
        public void ElevatorControl_ShouldMoveAPassengerFromGroundFloorToLeveL5()
        {
            List<Passenger> passengers = new List<Passenger>
            {
                new Passenger("John", "Mike", new Floor(0), new Floor(5), Direction.UP)
            };

            Floor elevatorPosition = new Floor(0);
            Elevator elevator = new Elevator(passengers, elevatorPosition, Direction.DOWN);

            elevator.Travel();
            elevator.Stop();

            Assert.Equal(5, elevator.Position.Position);
            Assert.Empty(elevator.Passengers);
        }

        //* Passenger summons lift on level 6 to go down.Passenger on level 4 summons the lift to go down.They both choose L1.
        [Fact]
        public void ElevatorControl_ShouldMoveTwoPassengerFromDifferentdFloorsToLeveL1()
        {
            List<Passenger> passengers = new List<Passenger>
            {
                new Passenger("John", "Mike", new Floor(6), new Floor(1), Direction.DOWN),
                new Passenger("Jane", "Kloe", new Floor(4), new Floor(1), Direction.DOWN)
            };

            Floor elevatorPosition = new Floor(0);
            Elevator elevator = new Elevator(passengers, elevatorPosition, Direction.DOWN);

            elevator.Travel();
            elevator.Stop();

            Assert.Equal(1, elevator.Position.Position);
            Assert.Empty(elevator.Passengers);
        }

        //* Passenger 1 summons lift to go up from L2.Passenger 2 summons lift to go down from L4.Passenger 1 chooses to go to L6.Passenger 2 chooses to go to Ground Floor

        [Fact]
        public void ElevatorControl_ShouldMoveTwoPassengerFromDifferentdFloorsToDifferentFloors()
        {
            Passenger passenger1 = new Passenger("John", "Mike", new Floor(2), new Floor(6), Direction.UP);
            Passenger passenger2 = new Passenger("Jane", "Kloe", new Floor(4), new Floor(0), Direction.DOWN);

            List<Passenger> passengers = new List<Passenger>
            {
                passenger1, passenger2

            };

            Elevator elevator = new Elevator(passengers, new Floor(0), Direction.UP);


            Assert.Equal(2, elevator.Passengers.Count);


            elevator.Travel();
            elevator.Stop();

            Assert.Equal(passenger1, elevator.Passengers.FirstOrDefault());
            Assert.Equal(1, elevator.Passengers.Count);

            elevator.Travel();
            elevator.Stop();

            Assert.Empty(elevator.Passengers);
            Assert.Equal(0, elevator.Passengers.Count);
        }

        //* Passenger 1 summons lift to go up from Ground.They choose L5.Passenger 2 summons lift to go down from L4.Passenger 3 summons lift to go down from L10.Passengers 2 and 3 choose to travel to Ground.


        [Fact]
        public void ElevatorControl_ShouldMoveTMoreThanwoPassengerFromDifferentdFloorsToDifferentFloors()
        {
            Passenger passenger1 = new Passenger("John", "Mike", new Floor(0), new Floor(5), Direction.UP);
            Passenger passenger2 = new Passenger("Jane", "Kloe", new Floor(4), new Floor(0), Direction.DOWN);
            Passenger passenger3 = new Passenger("Jane", "Kloe", new Floor(10), new Floor(0), Direction.DOWN);

            List<Passenger> passengers = new List<Passenger>
            {
                passenger1, passenger2, passenger3

            };

            Elevator elevator = new Elevator(passengers, new Floor(0), Direction.UP);


            Assert.Equal(3, elevator.Passengers.Count);


            elevator.Travel();
            elevator.Stop();

            Assert.Equal(passenger1, elevator.Passengers.FirstOrDefault());
            Assert.Equal(1, elevator.Passengers.Count);

            elevator.Travel();
            elevator.Stop();

            Assert.Empty(elevator.Passengers);
            Assert.Equal(0, elevator.Passengers.Count);
        }
    }
}
