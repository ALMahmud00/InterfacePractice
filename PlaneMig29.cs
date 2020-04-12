using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class PlaneMig29 : IWeapon
    {
        public void Bomb()
        {
            Console.WriteLine("==============================>> Mig29 : Dropping Bomb");
        }

        public void Laser()
        {
            Console.WriteLine("==============================>> Mig29 : Firing Laser");
        }

        public void MachineGun()
        {
            Console.WriteLine("==============================>> Mig29 : Firing Machine Gun");
        }

        public void Missile()
        {
            Console.WriteLine("==============================>> Mig29 : Firing Missile");
        }

    }
}
