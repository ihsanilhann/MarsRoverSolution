namespace MarsRoverProject
{
    // Class to define rotational movements to west.
    class WestRotation : IRotation
    {
        // Create instance once
        private static WestRotation WestRotationObj = null;

        // Private for single object
        private WestRotation()
        {
        }

        // Instance producer and provider of class
        public static IRotation GetInstance()
        {
            if (WestRotationObj == null)
            {
                WestRotationObj = new WestRotation();
            }

            return WestRotationObj;
        }

        // Move on direction
        public void Move(ref TwoDimSurface prev)
        {
            prev.BackwardOnX();
        }

        // Rotation to the left
        public IRotation TurnLeft()
        {
            return RotationFactory.GetInstance("s");
        }

        // Rotation to the right
        public IRotation TurnRight()
        {
            return RotationFactory.GetInstance("n");
        }

        // Getter function for rotation info
        public string GetRotationName()
        {
            return "W";
        }
    }
}
