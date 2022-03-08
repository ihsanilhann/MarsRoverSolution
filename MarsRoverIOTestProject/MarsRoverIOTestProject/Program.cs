using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverProject;

namespace MarsRoverIOTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsRover mRover = new MarsRover();
            mRover.CreateSurface(args[0]);

            Int32 i = 1;
            while (i < args.Length)
            {
                mRover.SetPosition(args[i++]);
                mRover.Action(args[i++]);
                mRover.PrintInfo();
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
