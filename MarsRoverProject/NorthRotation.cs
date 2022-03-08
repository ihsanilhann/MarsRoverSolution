namespace MarsRoverProject
{
    // Class to define rotational movements to north.
    class NorthRotation : IRotation
    {
        // Create instance once
        private static NorthRotation NorthRotationObj = null;

        // Private for single object
        private NorthRotation()
        {
        }

        // Instance producer and provider of class
        public static IRotation GetInstance()
        {
            // Define once if not instantiated
            if (NorthRotationObj == null)
            {
                NorthRotationObj = new NorthRotation();
            }

            return NorthRotationObj;
        }

        // Move on direction
        public void Move(ref TwoDimSurface prev)
        {
            prev.ForwardOnY();
        }

        // Rotation to the left
        public IRotation TurnLeft()
        {
            return RotationFactory.GetInstance("w");
        }

        // Rotation to the right
        public IRotation TurnRight()
        {
            return RotationFactory.GetInstance("e");
        }

        // Getter function for rotation info
        public string GetRotationName()
        {
            return "N";
        }
    }
}
