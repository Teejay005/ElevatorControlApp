using System;
namespace ElevatorControl
{
    public class Floor
    {
        public Floor(int Position)
        {
            this.Position = Position;
        }

        public int Position
        {
            get;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Floor floor))
            {
                return false;
            }
            return this.Position.Equals(floor.Position);
        }

        public override int GetHashCode()
        {
            return this.Position.GetHashCode();
        }
    }
}
