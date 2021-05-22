using CER.Application.Contracts;
using CER.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER.Application.Implementations
{
    public class CuriousRover : ICuriousRover, IMovements
    {
        public IPlateau Plateau { get; set; }
        public IPosition Position { get; set; }
        public Directions Facing { get; set; }


        public CuriousRover(IPlateau plateau, IPosition position, Directions facing)
        {
            Plateau = plateau;
            Position = position;
            Facing = facing;
        }

        public void StartMoving(string letters)
        {
            foreach (var letter in letters)
            {
                ProcessLetter(letter);
            }
        }

        private void ProcessLetter(char letter)
        {
            // Check whether if position-x and position-y are in boundary of plateau
            if (Position.X < 0 || Position.X > Plateau.PointX || Position.Y < 0 || Position.Y > Plateau.PointY)
            {
                throw new Exception($"Position X and Position Y should be in boundaries of ({Plateau.PointX},{Plateau.PointY})");
            }

            switch (letter)
            {
                case ('L'):
                    Spin90Left();
                    break;
                case ('R'):
                    Spin90Right();
                    break;
                case ('M'):
                    MoveForward();
                    break;
                default:
                    throw new ArgumentException($"Invalid letter from NASA {letter}.");
            }

           


        }

        public void MoveForward()
        {
            switch (Facing)
            {
                case Directions.N:
                    Position.Y++;
                    break;
                case Directions.S:
                    Position.Y--;
                    break;
                case Directions.E:
                    Position.X++;
                    break;
                case Directions.W:
                    Position.X--;
                    break;
                default:
                    break;
            }
        }

        public void Spin90Left()
        {
            switch (Facing)
            {
                case Directions.N:
                    Facing = Directions.W;
                    break;
                case Directions.S:
                    Facing = Directions.E;
                    break;
                case Directions.E:
                    Facing = Directions.N;
                    break;
                case Directions.W:
                    Facing = Directions.S;
                    break;
                default:
                    break;
            }
        }

        public void Spin90Right()
        {
            switch (Facing)
            {
                case Directions.N:
                    Facing = Directions.E;
                    break;
                case Directions.S:
                    Facing = Directions.W;
                    break;
                case Directions.E:
                    Facing = Directions.S;
                    break;
                case Directions.W:
                    Facing = Directions.N;
                    break;
                default:
                    break;
            }
        }

        public string GetCurrentPosition()
        {
            return string.Format(
                "{0} {1} {2}",
                Position.X,
                Position.Y,
                Facing);
        }
    }
}
