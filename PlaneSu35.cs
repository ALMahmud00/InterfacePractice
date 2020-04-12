using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class PlaneSu35 : IWeapon
    {
        public void Bomb()
        {
            Console.WriteLine("==============================>> Su35 : Dropping Bomb");
        }

        public void Laser()
        {
            Console.WriteLine("==============================>> Su35 : Firing Laser");
        }

        public void MachineGun()
        {
            Console.WriteLine("==============================>> Su35 : Firing Machine Gun");
        }

        public void Missile()
        {
            Console.WriteLine("==============================>> Su35 : Firing Missile");
        }

    }
}
