### Elevator App Description.

#### QUESTION

```
You are in charge of writing software for an elevator (lift) company.

Your task is to write a program to control the travel of a the lift for a 10 storey building.

 

A passenger can summon the lift to go up or down from any floor, once in the lift they can choose the floor they’d like to travel to.

 

Your program needs to plan the optimal set of instructions for the lift to travel, stop,  and open its doors.

 

Some test cases:

* Passenger summons lift on the ground floor. Once in chooses to go to level 5.

* Passenger summons lift on level 6 to go down. Passenger on level 4 summons the lift to go down. They both choose L1.

* Passenger 1 summons lift to go up from L2. Passenger 2 summons lift to go down from L4. Passenger 1 chooses to go to L6. Passenger 2 chooses to go to Ground Floor

* Passenger 1 summons lift to go up from Ground. They choose L5. Passenger 2 summons lift to go down from L4. Passenger 3 summons lift to go down from L10. Passengers 2 and 3 choose to travel to Ground.

```

#### SOLUTION

1. The class Passenger holds the information about each passenger in the elevator.

2. Main class in the Elevator class, which determines which passenger to pick first, when to stop and who comes down last.

#### Assumption

1. It is assumed that the Ground floor is Level 0
2. Also, It is assumed that the elevator will always be at the ground floor at each time before any passenger makes any request.


#### How to run the App

1. Install [dotNetCore](https://dotnet.microsoft.com/download/dotnet-core/2.1)
2. Clone the app from [github repo]