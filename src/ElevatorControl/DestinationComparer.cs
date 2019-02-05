using System;
using System.Collections.Generic;

namespace ElevatorControl
{
    public class DestinationComparer : IComparer<Passenger>
    {
        public int Compare(Passenger x, Passenger y)
        {
            return x.Destination.Position.CompareTo(y.Destination.Position);
        }
    }
}
