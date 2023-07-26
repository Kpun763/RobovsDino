using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Dinosaur
    {
         public string Name;
         public int Health;
         public int AttackPower;

        public Dinosaur(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public void AttackRobot(Robot robot)
        {
            robot.Health -=AttackPower;
            Console.WriteLine($"{Name} attacks {robot.Name} with {AttackPower} attack power.");
        }
    }
}
