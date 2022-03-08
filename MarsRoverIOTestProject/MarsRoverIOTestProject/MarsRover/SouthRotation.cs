namespace MarsRoverProject
{
    // Class to define rotational movements to south.
    class SouthRotation : IRotation
    {
        // Create instance once
        private static SouthRotation SouthRotationObj = null;

        // Private for single object
        private SouthRotation()
        {
        }

        // Instance producer and provider of class
        public static IRotation GetInstance()
        {
            if(SouthRotationObj == null)
            {
                SouthRotationObj = new SouthRotation();
            }
            return SouthRotationObj;
        }

        // Move on direction
        public void Move(ref TwoDimSurface prev)
        {
            prev.BackwardOnY();
        }

        // Rotation to the left
        public IRotation TurnLeft()
        {
            return RotationFactory.GetInstance("e"); 
        }

        // Rotation to the right
        public IRotation TurnRight()
        {
            return RotationFactory.GetInstance("w"); 
        }

        // Getter function for rotation info
        public string GetRotationName()
        {
            return "S";
        }
    }
}
