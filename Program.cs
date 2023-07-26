using Microsoft.Win32.SafeHandles;

namespace Robot_vs_Dinosaur_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon laser = new Weapon("Laser", 20);
            
            Robot robot = new Robot("R2D2", 100, laser);

            Dinosaur dino = new Dinosaur("T-rex", 120, 20);

            Battlefield battlefield = new Battlefield();
           
            battlefield.RunGame(robot, dino);
        }
    }
}