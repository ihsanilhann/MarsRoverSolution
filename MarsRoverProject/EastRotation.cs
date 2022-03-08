namespace MarsRoverProject
{
    // Class to define rotational movements to east. 
    class EastRotation : IRotation
    {
        // Create instance once
        private static EastRotation EastRotationObj = null;

        // Private for single object
        private EastRotation()
        {
        }

        // Instance producer and provider of class
        public static IRotation GetInstance()
        {
            // Define once if not instantiated
            if(EastRotationObj == null)
            {
                EastRotationObj = new EastRotation();
            }
            return EastRotationObj;
        }

        // Move on direction
        public void Move(ref TwoDimSurface prev)
        {
            prev.ForwardOnX();
        }

        // Rotation to the left
        public IRotation TurnLeft()
        {
            return RotationFactory.GetInstance("n");
        }

        // Rotation to the right
        public IRotation TurnRight()
        {
            return RotationFactory.GetInstance("s");
        }

        // Getter function for rotation info
        public string GetRotationName()
        {
            return "E";
        }
    }
}
