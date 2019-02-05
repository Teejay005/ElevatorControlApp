using System;
using System.Collections.Generic;
using System.Linq;


namespace ElevatorControl
{
    public class Elevator
    {
        public Elevator(List<Passenger> passengers, Floor position, Direction directionOfTravelling)
        {
            this.Passengers = passengers;
            this.Position = position;
            this.DirectionOfTravelling = directionOfTravelling;
        }

        public List<Passenger> Passengers
        {
            get; private set;
        }

        public Floor Position
        {
            get; private set;
        }

        public Direction DirectionOfTravelling
        {
            get;
        }

        public void Travel()
        {
            List<Passenger> passengersInDirectionOfElevator = GetPassengersMovingInDirectionOfElevator();

            if (passengersInDirectionOfElevator.Count > 0)
            {
                passengersInDirectionOfElevator.OrderBy(p => p.Destination.Position).ToList();
                this.Position = passengersInDirectionOfElevator.LastOrDefault().Destination;
            }
            else if(Passengers.Count > 0)
            {
                Passengers.OrderBy(p => p.Destination.Position).ToList();
                this.Position = Passengers.LastOrDefault().Destination;
            }
        }


        public void Stop()
        {
            OpenDoor();
        }

        public void OpenDoor()
        {
            foreach (Passenger passenger in GetPassengersWhoseDestinationIsTheElevationStopPosition())
            {
                this.Passengers.Remove(passenger);
            }
        }

        private List<Passenger> GetPassengersMovingInDirectionOfElevator()
        {
            return this.Passengers.Where(p => p.Direction == this.DirectionOfTravelling).ToList();
        }

        private List<Passenger> GetPassengersWhoseDestinationIsTheElevationStopPosition()
        {
           
            return this.Passengers.Where(p => p.Destination.Position == this.Position.Position).ToList();
        }
    }
}
