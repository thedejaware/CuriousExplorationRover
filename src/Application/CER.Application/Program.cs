using CER.Application.Enums;
using CER.Application.Implementations;
using System;
using System.Linq;

namespace CER.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Hard coded position and plateau values
                ProcessWithObject();

                // Getting values from Console
                //ProcessFromConsole();

            }
            catch (Exception exc)
            {
                Console.WriteLine($"An error occured: {exc.Message}");
                Console.ReadLine();
            }

        }

        static void ProcessFromConsole()
        {

            Console.WriteLine("Please type Plateau Points");

            // Read Plateau Points from console
            var plateauPoints = Console.ReadLine().Trim().Split(' ');

            Console.WriteLine("Please type Positions and Facing Direction");
            // Read Positions and Facing Direction
            var positions = Console.ReadLine().Trim().Split(' ');

            // If plateau points do not exist or more than 2, throw exception
            if (plateauPoints.Count() != 2)
                throw new ArgumentException($"Please type two plateau points.");

            // If positions and facing direction do not exist or more than 3, throw exception
            if (positions.Count() != 3)
                throw new ArgumentException($"Please type two positions and one facing direction.");


            // Create plateau instance
            Plateau plateau = new Plateau(
                Convert.ToInt32(plateauPoints[0]),
                Convert.ToInt32(plateauPoints[1])
            );

            // Create position instance
            Position position = new Position(
                Convert.ToInt32(positions[0]),
                Convert.ToInt32(positions[1])
            );


            Console.WriteLine("Please type the Letters");
            // Read Letters from console
            var letters = Console.ReadLine().ToUpper();


            // Create curious rover instacne
            CuriousRover rover = new CuriousRover(
                plateau,
                position,
                (Directions)Enum.Parse(typeof(Directions), positions[2])
            );



            // Curious Rover starts moving
            rover.StartMoving(letters);

            // Get current location after moving
            Console.WriteLine($"Current position of the curious rover is: \r\n{rover.GetCurrentPosition()}");

            Console.ReadLine();
        }

        static void ProcessWithObject()
        {
            // Create plateau instance
            Plateau plateau = new Plateau(5, 5);

            #region First Curious Rover

            // Create position instance
            Position firstPosition = new Position(1, 2);

            // Create curious rover instacne
            CuriousRover firstRover = new CuriousRover(
                plateau,
                firstPosition,
                Directions.N
            );

            // Curious Rover starts moving
            firstRover.StartMoving("LMLMLMLMM");

            // Get current location after moving
            Console.WriteLine($"Current position of the first curious rover is: \r\n{firstRover.GetCurrentPosition()}");


            #endregion

            #region Second Curious Rover
            // Create position instance
            Position secondPosition = new Position(3, 3);

            // Create curious rover instacne
            CuriousRover secondRover = new CuriousRover(
                plateau,
                secondPosition,
                Directions.E
            );

            // Curious Rover starts moving
            secondRover.StartMoving("MMRMMRMRRM");

            // Get current location after moving
            Console.WriteLine($"Current position of the second curious rover is: \r\n{secondRover.GetCurrentPosition()}");

            #endregion



        }
    }
}
