using System;

namespace MarsRoverProject
{
    // Class to generate 2D surface. Surface might have some limitations, for instance
    // any axis might be limited within some boundaries. Here, we create a 2-D surface 
    // with axis-X and axis-Y. If no limitation defined, boundaries of axis get maximum
    // and minimum of 32-bit integer. Also we could mark a point that we can change. 
    // This point could be assumed as an object on surface that have ability to move
    // on limited surface.
    public class TwoDimSurface
    {
        // Axises for 2 dimension
        private readonly Axis Axis_X = null;
        private readonly Axis Axis_Y = null;

        // Step size to move forward/backward(specified for this application)
        private const Int32 ONE_TICK_STEP = 1;

        // Constructor of surface
        public TwoDimSurface(Int32 max_x, Int32 max_y, Int32 min_x, Int32 min_y)
        {
            // Creation of x-axis
            Axis_X = new Axis(min_x, max_x);

            // Creation of y-axis
            Axis_Y = new Axis(min_y, max_y);
            
        }

        // Update marked point
        public void UpdateMarkedPoint(Int32 xi, Int32 yi)
        {
            Axis_X.markedPoint = xi;
            Axis_Y.markedPoint = yi;
        }

        // Move forward on x-axis
        public void ForwardOnX()
        {
            Axis_X.StepForward(ONE_TICK_STEP);
        }

        // Move forward on y-axis
        public void ForwardOnY()
        {
            Axis_Y.StepForward(ONE_TICK_STEP);
        }

        // Move backward on x-axis
        public void BackwardOnX()
        {
            Axis_X.StepBack(ONE_TICK_STEP);
        }

        // Move backward on y-axis
        public void BackwardOnY()
        {
            Axis_Y.StepBack(ONE_TICK_STEP);
        }

        // Get position of marker on x-axis
        public Int32 GetCurrentX()
        {
            return Axis_X.markedPoint;
        }

        // Get position of marker on y-axis
        public Int32 GetCurrentY()
        {
            return Axis_Y.markedPoint;
        }

    }
}
