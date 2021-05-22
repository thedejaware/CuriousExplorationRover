using CER.Application.Enums;
using CER.Application.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CER.Tests
{
    [TestClass]
    public class CuriousRoverTests
    {
        [TestMethod]
        // StartMoving_Scenario_ExpectedBehavior
        public void StartMoving_Input12N_Output13N()
        {
            // Arrange
            // Create plateau instance
            Plateau plateau = new Plateau(5, 5);
            // Create position instance
            Position position = new Position(1, 2);

            // Create curious rover instacne
            CuriousRover rover = new CuriousRover(
                plateau,
                position,
                Directions.N
            );

            var letters = "LMLMLMLMM";

            // Act
            rover.StartMoving(letters);
            var actualOutput = rover.GetCurrentPosition();
            var expectedOutput = "1 3 N";

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestMethod]
        // StartMoving_Scenario_ExpectedBehavior
        public void StartMoving_Input33E_Output51E()
        {
            // Arrange
            // Create plateau instance
            Plateau plateau = new Plateau(5, 5);
            // Create position instance
            Position position = new Position(3, 3);

            // Create curious rover instacne
            CuriousRover rover = new CuriousRover(
                plateau,
                position,
                Directions.E
            );

            var letters = "MMRMMRMRRM";

            // Act
            rover.StartMoving(letters);
            var actualOutput = rover.GetCurrentPosition();
            var expectedOutput = "5 1 E";

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid letter sent by NASA")]
        // ProcessLetter_Scenario_ExpectedBehavior
        public void ProcessLetter_IncorrectLetter_ThrowArgumentException()
        {
            // Arrange
            // Create plateau instance
            Plateau plateau = new Plateau(5, 5);
            // Create position instance
            Position position = new Position(3, 3);

            // Create curious rover instacne
            CuriousRover rover = new CuriousRover(
                plateau,
                position,
                Directions.E
            );

            var letters = "LMLMLMZMM";


            // Act
            foreach (var letter in letters)
            {
                rover.ProcessLetter(letter);
            }

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Positions are out of boundaries")]
        // CheckBoundary_Scenario_ExpectedBehavior
        public void CheckBoundary_OutOfBoundary_ThrowArgumentException()
        {
            // Arrange
            // Create plateau instance
            Plateau plateau = new Plateau(5, 5);
            // Create position instance
            Position position = new Position(6, 3);

            // Create curious rover instacne
            CuriousRover rover = new CuriousRover(
                plateau,
                position,
                Directions.E
            );

            // Act
            rover.CheckBoundary();

            // Assert
        }

    }
}
