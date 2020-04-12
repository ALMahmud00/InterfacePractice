using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class PlaneF22 : IWeapon
    {
        public void Bomb()
        {
            Console.WriteLine("==============================>> F22 : Dropping Bomb");
        }

        public void Laser()
        {
            Console.WriteLine("==============================>> F22 : Firing Laser");
        }

        public void MachineGun()
        {
            Console.WriteLine("==============================>> F22 : Firing Machine Gun");
        }

        public void Missile()
        {
            Console.WriteLine("==============================>> F22 : Firing Missile");
        }
      
    }
}
