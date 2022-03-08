namespace MarsRoverProject
{
    // Interface for common operation to rotate rover
    public interface IRotation
    {
        IRotation TurnLeft();
        IRotation TurnRight();
        void Move(ref TwoDimSurface prev);
        string GetRotationName();
    }
}
