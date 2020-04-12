using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Please select your plane: ");

            Console.WriteLine("1: F22");
            Console.WriteLine("2: Mig29");
            Console.WriteLine("3: Mirage5");
            Console.WriteLine("4: Su35");

            int choice = Convert.ToInt32(Console.ReadLine());

            FiringWeapon firingWeapon = new FiringWeapon();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have Selected F22\n====================================");
                    firingWeapon.Show(new PlaneF22());
                    break;
                case 2:
                    Console.WriteLine("You have Selected Mig29\n====================================");
                    firingWeapon.Show(new PlaneMig29());
                    break;
                case 3:
                    Console.WriteLine("You have Selected Mirage5\n====================================");
                    firingWeapon.Show(new PlaneMirage5());
                    break;
                case 4:
                    Console.WriteLine("You have Selected Su35\n====================================");
                    firingWeapon.Show(new PlaneSu35());
                    break;
                default:
                    break;
            }
        }
    }
}
