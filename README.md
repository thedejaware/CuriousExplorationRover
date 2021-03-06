# Code Review: Mars Rover (Curious Exploration Rover)
Curious Exploration Rover on Mars

Solution consists of two projects. One is Console Application Project and the other one is Test Project.

To run the project, you will need the following tools;
- Visual Studio 2019
- .Net 5.0 or later

Interface definitions have been created under the Contracts folder. And Implementation or Concrete classes have been created under the Implementations folder.

** In Program.cs file, there are optionally two methods to run;
1. ProcessWithObject() => Plateau, Position and Letter values are hard-coded in this method. You can directly call to see the expected outputs
1. ProcessFromConsole() => You can set Plateau, Position and Letter values from the Console. When you execute the method, it will ask you for the input parameters.


### Understanding the Input Parameters for the first Rover;

**FIRST INPUT:** 5 5 => X-axis and Y-axis of Plateau

Following image shows the Plateau which is divided up into a grid. 
X-axis of 5
Y-axis of 5 

![enter image description here](https://drive.google.com/uc?export=download&id=1n8kRgjZGxfPgzbu58ZZKh3Cn3UdgWQzR)

Our curious rover will move on this plateau with given positions. 

**SECOND INPUT:** 1 2 N => Starting positions of our rover.
- 1: X coordinate of our curious rover
- 2: Y coordinate of our curious rover
- N: Rover is facing or looking the North.

**The following image shows the starting position of the rover.** Rocket icon represents the rover :-)

![enter image description here](https://drive.google.com/uc?export=download&id=1Gp8hpXfnqof3ZpjeV2owa_i7BrpYj-ib)

**THIRD INPUT: ** LMLMLMLMM => Letters sent by NASA to control the rover:
- L: Rotates the rover 90 degrees left
- R: Rotates the rover 90 degrees right
- M: Move forward one grid point.

When we execute the project with given inputs, final location or position of our curious rover will be **"1 3 N"**.

The following image shows the position of first rover when it has finished moving.

![enter image description here](https://drive.google.com/uc?export=download&id=1k4lIW3tk-Eo0iFeX2nkgP6NT0xl5jwMZ)

### Input Parameters for the second Rover;

3 3 E

MMRMMRMRRM

When we execute the project with given inputs, final location or position of our second curious rover will be **"5 1 E"**

The following image shows the position of second rover when it has finished moving.

![enter image description here](https://drive.google.com/uc?export=download&id=11sAglmpgrnb6TAO_EYNraiFD9ONnoA8S)




