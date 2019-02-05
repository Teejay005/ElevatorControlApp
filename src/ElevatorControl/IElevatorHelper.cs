using System;
using System.Collections.Generic;

namespace ElevatorControl
{
    public interface IElevatorHelper
    {
        Floor FindClosestPassenger(Elevator elevator);

        List<Passenger> FindPassengerAtDestination(Elevator elevator);
    }
}
