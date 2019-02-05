using System;
using System.Collections.Generic;
using System.Linq;

namespace ElevatorControl
{
    public class ElevatorHelper : IElevatorHelper
    {
        public Floor FindClosestPassenger(Elevator elevator)
        {
            return elevator.Passengers.OrderBy(p => p.StartingPosition.Position)
                .ToList()
                .FirstOrDefault()
                .StartingPosition;
        }

        public List<Passenger> FindPassengerAtDestination(Elevator elevator)
        {
            List<Passenger> passengersAtStop = new List<Passenger>();
            foreach (Passenger passenger in elevator.Passengers)
            {
                if (passenger.Destination.Equals(elevator.Position))
                {
                    passengersAtStop.Add(passenger);
                }
            }
            return passengersAtStop;
        }
    }
}
