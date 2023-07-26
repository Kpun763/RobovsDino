using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Robot
    {
        public string Name;
        public int Health;
        public Weapon ActiveWeapon;

        public Robot(string name, int health, Weapon activeweapon)
        {
            Name = name;
            Health = health;
            ActiveWeapon = activeweapon;

        }
        public void AttackDinosaur(Dinosaur dinosaur)
        {
            dinosaur.Health -= ActiveWeapon.AttackPower;
            Console.WriteLine($"{Name} attacks {dinosaur.Name} with {ActiveWeapon.Type} and {ActiveWeapon.AttackPower} attack power");
        }
       
      
    }  
}
