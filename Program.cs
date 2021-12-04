using System;

namespace Energy_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int startEnergy = 3;
            int energyUsed = 0;
            int energyGain = 0;
            int roundEnergy = 2;
            int currentEnergy = 0;
            int energySteal = 0;
            int Energy = 0;

            //First Round Energy Gains

            System.Console.WriteLine("Number of Energy Enemy Used");
            energyUsed = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Number of Energy You Stole");
            energySteal = Convert.ToInt32(System.Console.ReadLine());
    
            System.Console.WriteLine("Number of Energy Enemy Gained");
            energyGain = Convert.ToInt32(System.Console.ReadLine());
            

            Energy = startEnergy + energyGain;
            currentEnergy = Energy - energyUsed;
            currentEnergy = currentEnergy - energySteal;
        
            currentEnergy = currentEnergy + roundEnergy;

            System.Console.WriteLine("Enemy has " + currentEnergy + "Energy");

            

            //Next Round Button
            System.Console.WriteLine("Press Space for the next round");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar){}

            //Round 2 and Above Energy Gains
            for (int i = 0; i < 16; i++)
            {
 
            currentEnergy = CountEnergy(currentEnergy);

            System.Console.WriteLine("Enemy has " + currentEnergy + "Energy");

            System.Console.WriteLine("Press Space for the next round");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar){}


            //Count Energy Function
            int CountEnergy (int currentEnergy)
            {

                System.Console.WriteLine("Number of Energy Enemy Used");
                energyUsed = Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("Number of Energy You Stole");
                energySteal = Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("Number of Energy Enemy Gained");
                energyGain = Convert.ToInt32(System.Console.ReadLine());

                currentEnergy = currentEnergy - energyUsed;
                currentEnergy = currentEnergy + energyGain;
                currentEnergy = currentEnergy - energySteal;
                currentEnergy = currentEnergy + roundEnergy;

                return currentEnergy;

                }

             }   
        }
    }
}
