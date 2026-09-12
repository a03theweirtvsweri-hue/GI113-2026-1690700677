/*
 * Student ID : 1690700677
 * Name       : Witawat Thawon
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System;


namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
                  
                const string GameTitle = "Wuthering Waves";

                var characterName = "Jiyan";
                var characterRank = 'S';

                int characterLevel = 80;
                float attackPower = 1250.5f;
                double resonanceEnergy = 87.6;
                bool isAvailable = true;

                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine($"║          {GameTitle}          ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine($"║ Character : {characterName}");
                Console.WriteLine($"║ Rank      : {characterRank}");
                Console.WriteLine($"║ Level     : {characterLevel}");
                Console.WriteLine($"║ Attack    : {attackPower}");
                Console.WriteLine($"║ Energy    : {resonanceEnergy}");
                Console.WriteLine($"║ Available : {isAvailable}");
                Console.WriteLine("╚══════════════════════════════════════╝");

                Console.WriteLine();

                double levelAsDouble = characterLevel;
                Console.WriteLine($"Level as double (implicit): {levelAsDouble}");

                int energyCast = (int)resonanceEnergy;
                int energyConvert = Convert.ToInt32(resonanceEnergy);

                Console.WriteLine($"Energy cast (truncates): {energyCast}");
                Console.WriteLine($"Energy Convert (rounds): {energyConvert}");
            
        }
    }
       
}
