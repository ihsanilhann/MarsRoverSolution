using System;
using System.Linq;
using MarsRoverProject.Exceptions;

namespace MarsRoverProject
{
    public class MarsRover
    {
        // Info of location and rotation of rover
        private IRotation RoverRotation = null;
        private TwoDimSurface MarsArea = null;

        public MarsRover()
        {
        }

        // To create surface, input string should be in the format "Xmax Ymax"
        // Thus, it contains one space to understand where to split
        public void CreateSurface(string surf)
        {
            // First check validity of input
            if (!string.IsNullOrEmpty(surf))
            {
                const Int32 EXPECTED_ARG_COUNT = 2;
                // Now check the format
                if (surf.Contains(' '))
                {
                    // Split into 2
                    string[] info = surf.Split(' ');

                    // Input 
                    Int32 xMax = Convert.ToInt32(info[0]);
                    Int32 yMax = Convert.ToInt32(info[1]);
                    
                    // Now create surface
                    MarsArea = new TwoDimSurface(xMax, yMax, 0, 0);
                }
                else
                {
                    // Improper input format
                    throw new NotEnoughArgumentException((EXPECTED_ARG_COUNT).ToString() + " parameters required.");
                }
            }
            else
            {
                // Invalid or empty input
                throw new NullReferenceException("Input cannot be null or empty");
            }
        }

        // To put the rover into correct position and location, input string
        // should be in the format of "Xr Yr Pr". Thus, it contains 2 spaces
        // to interpret info about rover
        public void SetPosition(string roverInfo)
        {
            // First check validity of input
            if (!string.IsNullOrEmpty(roverInfo))
            {
                // Now check the format
                if (roverInfo.Contains(' '))
                {
                    // Split into 3
                    string[] info = roverInfo.Split(' ');
                    const Int32 EXPECTED_ARG_COUNT = 3;
                    if (info.Length == EXPECTED_ARG_COUNT)
                    {
                        Int32 x = Convert.ToInt32(info[0]);
                        Int32 y = Convert.ToInt32(info[1]);

                        // Update rover start position
                        MarsArea.UpdateMarkedPoint(x, y);

                        // Update rover initial rotation
                        RoverRotation = RotationFactory.GetInstance(info[2]);
                    }
                    else
                    {
                        // Improper input format
                        throw new NotEnoughArgumentException((EXPECTED_ARG_COUNT).ToString() + " parameters required.");
                    }
                }
                else
                {
                    // Improper input format
                    throw new ArgumentException("Argument should have at least one space", nameof(roverInfo));
                }
            }
            else
            {
                // Invalid or empty input
                throw new NullReferenceException("Input cannot be null or empty");
            }
        }

        // Trigger corresponding action according to input set
        public void Action(string actionSet)
        {
            if (this.MarsArea == null)
            {
                throw new SurfaceNotCreatedException("Surface not created");
            }
            else if (this.RoverRotation == null)
            {
                throw new RotationNotInitializedException("No rotation found");
            }
            else
            {
                foreach (var action in actionSet)
                {
                    // Command to rotate on left
                    if (action == 'L')
                    {
                        RoverRotation = RoverRotation.TurnLeft();
                    }
                    // Command to rotate on right
                    else if (action == 'R')
                    {
                        RoverRotation = RoverRotation.TurnRight();
                    }
                    // Command to move on
                    else if (action == 'M')
                    {
                        RoverRotation.Move(ref MarsArea);
                    }
                    // Rest is invalid
                    else
                    {
                        // No operable action
                        throw new InvalidCommandException("Command " + action.ToString() + " is invalid.");
                    }
                }
            }
        }

        public Int32[] GetPosition()
        {
            var ret = new Int32[2] { MarsArea.GetCurrentX(), MarsArea.GetCurrentY() };
            return ret;
        }

        public string GetRotation()
        {
            return this.RoverRotation.GetRotationName();
        }

        // State the latest position and rotation of rover
        public void PrintInfo()
        {
            Console.WriteLine(MarsArea.GetCurrentX() + " " + 
                              MarsArea.GetCurrentY() + " " + 
                              RoverRotation.GetRotationName().ToUpper());
        }
    }
}
