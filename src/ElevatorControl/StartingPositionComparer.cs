using System;
using System.Collections.Generic;

namespace ElevatorControl
{
    public class StartingPositionComparer : IComparer<Passenger>
    {
        public int Compare(Passenger x, Passenger y)
        {
            return x.StartingPosition.Position.CompareTo(y.StartingPosition.Position);
        }
    }
}
