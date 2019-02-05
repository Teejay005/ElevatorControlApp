using System;
using System.Collections.Generic;

namespace ElevatorControl
{
    public class Passenger
    {
        public Passenger(string FirstName, string LastName, Floor StartingPosition, Floor Destination, Direction direction)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StartingPosition = StartingPosition;
            this.Destination = Destination;
        }

        public string LastName
        {
            get;
        }

        public string FirstName
        {
            get;
        }

        public Floor StartingPosition
        {
            get;
        }

        public Floor Destination
        {
            get;
        }

        public Direction Direction
        {
            get;
        }
    }
}
