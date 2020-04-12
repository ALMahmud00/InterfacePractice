using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class PlaneMirage5 : IWeapon
    {
        public void Bomb()
        {
            Console.WriteLine("==============================>> Mirage5 : Dropping Bomb");
        }

        public void Laser()
        {
            Console.WriteLine("==============================>> Mirage5 : Firing Laser");
        }

        public void MachineGun()
        {
            Console.WriteLine("==============================>> Mirage5 : Firing Machine Gun");
        }

        public void Missile()
        {
            Console.WriteLine("==============================>> Mirage5 : Firing Missile");
        }

    }
}
