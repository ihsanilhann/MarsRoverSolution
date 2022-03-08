using System;
using MarsRoverProject.Exceptions;


namespace MarsRoverProject
{
    // Class to define axis in the space. It could be used as 1-D dimensional applications.
    // We could limit the maximum and minimum value on axis. Also, we could mark a point 
    // to use in many applications, such as defining a coordinate of a target or destination
    // on a map...
    class Axis
    {
        // Limits of axis
        private Int32 MinLimit;
        private Int32 MaxLimit;
        private Int32 MarkedPoint;

        public Axis(Int32 min = Int32.MinValue, Int32 max = Int32.MaxValue)
        {
            // Check min max relation which min should be less than max
            if (max < min)
            {
                throw new WrongParameterException("Parameter should be set properly.");
            }
            else
            {
                this.MinLimit = min;
                this.MaxLimit = max;
                this.MarkedPoint = min;
            }
        }

        // Take a step into positive side
        public void StepForward(Int32 val)
        {
            // Control the boundary first
            if ((this.MaxLimit - this.MarkedPoint) >= val)
            {
                this.MarkedPoint += val;
            }
            else
            {
                throw new OutOfSurfaceException("Exceeded the maximum boundary.");
            }
        }

        // Take a step into negative side
        public void StepBack(Int32 val)
        {
            // Control the boundary first
            if ((this.MarkedPoint - this.MinLimit) >= val)
            {
                this.MarkedPoint -= val;
            }
            else
            {
                throw new OutOfSurfaceException("Exceeded the minimum boundary.");
            }
        }

        // Getter/setter of marked point
        public Int32 markedPoint
        {
            get { return this.MarkedPoint; }
            set
            {
                // Control the boundaries first
                if ((value > this.MaxLimit) || (value < this.MinLimit))
                {
                    throw new OutOfSurfaceException("Inaccessible point marked");
                }
                else
                {
                    this.MarkedPoint = value;
                }
            }
        }
    }
}
