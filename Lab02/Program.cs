/*
 * Student ID : 1690700677
 * Name       : Witawat Thawon
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");


            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%");
            Console.WriteLine();

            // Character 1: Knight
            string knightName = "Aiden";
            int knightHP = 150;
            double knightAttack = 75.5;
            float knightSpeed = 6.5f;
            bool knightHasShield = true;

            // Character 2: Mage
            string mageName = "Luna";
            int mageHP = 90;
            double mageMagicPower = 120.75;
            float mageMana = 85.5f;
            char mageRank = 'S';

            // Character 3: Archer
            string archerName = "Rin";
            int archerHP = 110;
            double archerAttack = 95.25;
            float archerAccuracy = 88.5f;
            bool archerHasBow = true;

            // Character 4: Assassin
            string assassinName = "Shadow";
            int assassinHP = 100;
            double assassinCritical = 45.75;
            float assassinSpeed = 12.5f;
            char assassinRank = 'A';


            // Display Knight Stats
            Console.WriteLine("=== Knight ===");
            Console.WriteLine($"Name: {knightName}");
            Console.WriteLine($"HP: {knightHP}");
            Console.WriteLine($"Attack: {knightAttack}");
            Console.WriteLine($"Speed: {knightSpeed}");
            Console.WriteLine($"Has Shield: {knightHasShield}");

            // Display Mage Stats
            Console.WriteLine("\n=== Mage ===");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"HP: {mageHP}");
            Console.WriteLine($"Magic Power: {mageMagicPower}");
            Console.WriteLine($"Mana: {mageMana}");
            Console.WriteLine($"Rank: {mageRank}");

            // Display Archer Stats
            Console.WriteLine("\n=== Archer ===");
            Console.WriteLine($"Name: {archerName}");
            Console.WriteLine($"HP: {archerHP}");
            Console.WriteLine($"Attack: {archerAttack}");
            Console.WriteLine($"Accuracy: {archerAccuracy}");
            Console.WriteLine($"Has Bow: {archerHasBow}");

            // Display Assassin Stats
            Console.WriteLine("\n=== Assassin ===");
            Console.WriteLine($"Name: {assassinName}");
            Console.WriteLine($"HP: {assassinHP}");
            Console.WriteLine($"Critical Chance: {assassinCritical}");
            Console.WriteLine($"Speed: {assassinSpeed}");
            Console.WriteLine($"Rank: {assassinRank}");
        }
    }
}
