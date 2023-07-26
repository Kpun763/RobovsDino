using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Battlefield
    {
        public void DisplayWelcomeMessage() 
        {
            Console.WriteLine("Welcome to the Robot vs Dinosaur Battle Project!");
            Console.WriteLine();
        }
        public void RunManinBattleSequence(Robot robot, Dinosaur dinosaur)
        {
            while (robot.Health > 0 && dinosaur.Health > 0)
            {
                robot.AttackDinosaur(dinosaur);
                dinosaur.AttackRobot(robot);
            }
        }

        public void AnnounceWinner(Robot robot, Dinosaur dinosaur)
        {
            if (robot.Health <= 0 && dinosaur.Health <= 0)
            {
                Console.WriteLine("It's a tie! Both the robot and the dinosaur are knocked out.");
            }
            else if (robot.Health <= 0)
            {
                Console.WriteLine($"{dinosaur.Name} wins.");
            }
            else
            {
                Console.WriteLine($"{robot.Name} wins.");
            }
                
        }
        public void RunGame(Robot robot, Dinosaur dinosaur)
        {
            DisplayWelcomeMessage();
            RunManinBattleSequence(robot, dinosaur);
            AnnounceWinner(robot, dinosaur);
        }
    }
}
