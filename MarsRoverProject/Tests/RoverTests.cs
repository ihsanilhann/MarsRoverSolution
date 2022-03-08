using System;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsRover m1 = new MarsRover();
            string[] input = {"5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM" }; 
            m1.CreateSurface(input[0]);

            Int32 i = 1;
            while (i < input.Length)
            {
                m1.SetPosition(input[i++]);
                m1.Action(input[i++]);
                m1.PrintInfo();
            }

            Console.ReadKey();
        }
    }
}
