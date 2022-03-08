using System;
using MarsRoverProject;

namespace MarsRoverIOTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skip operation if not enough input provided
            if (args.Length > 3)
            {
                // Create a rover and place on Mars
                MarsRover mRover = new MarsRover();
                mRover.CreateSurface(args[0]);

                Int32 i = 1;
                // Check to ensure that there is enough input for rover.
                while ( (i+2) <= args.Length)
                {
                    // First input is rover position
                    mRover.SetPosition(args[i++]);

                    // Second following argument is action set
                    mRover.Action(args[i++]);

                    // Now report final location of rover
                    mRover.PrintInfo();
                }

                // Say good bye to user
                Console.Write("Press any key to continue...");

                // Wait for a while
                Console.ReadKey();
            }
            else
            {
                // Warn user
                Console.WriteLine("Not enough argument provided from command line.");
            }
        }
    }
}
