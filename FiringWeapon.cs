using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class FiringWeapon
    {
        public void Show(IWeapon w)
        {
            int primary, secondary;

            Console.WriteLine("Select Primary Weapon:");
            Console.WriteLine("1: Bomb");
            Console.WriteLine("2: Machine Gun");
            Console.WriteLine("3: Missile");
            Console.WriteLine("4: Laser");
            primary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select Secondary Weapon:");
            Console.WriteLine("1: Bomb");
            Console.WriteLine("2: Machine Gun");
            Console.WriteLine("3: Missile");
            Console.WriteLine("4: Laser");
            secondary = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Please select your weapon command: ");
                Console.WriteLine("1: Primary");
                Console.WriteLine("2: Secondary");
                Console.WriteLine("3: Exit");

                int command = Convert.ToInt32(Console.ReadLine());

                if (command == 1)
                {
                    switch(primary)
                    {
                        case 1: w.Bomb(); break;
                        case 2: w.MachineGun(); break;
                        case 3: w.Missile(); break;
                        case 4: w.Laser(); break;
                    }
                }
                else if (command == 2)
                {
                    switch (secondary)
                    {
                        case 1: w.Bomb(); break;
                        case 2: w.MachineGun(); break;
                        case 3: w.Missile(); break;
                        case 4: w.Laser(); break;
                    }
                }
                else if (command == 3)
                {
                    break;
                }
                else { continue; }

            }
        }

    }
}
