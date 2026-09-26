/*
 * Student ID : 1690700677
 * Name       : Witawat Thawon
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;

            char menu;
            double amount;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to the Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            char.TryParse(Console.ReadLine(), out menu);

            Console.Write("=> How much would you like: ");
            bool amountValid = double.TryParse(Console.ReadLine(), out amount);

            if (amountValid && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double ingot = amount * SmeltRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double ore = amount / SalvageRate;

                    Console.WriteLine(
                        $"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: invalid menu.");
                }
            }
            else
            {
                Console.WriteLine("Error: invalid amount.");
            }






        }
    }
}
