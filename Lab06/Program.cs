/*
 * Student ID : 1690700677
 * Name       : Witawat Thawon
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */


namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int lives = 0;

            if (lives == 0)
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("You have " + lives + " lives left.");
            }

            int coins = 80;
            int prince = 100;

            if (coins >= prince)
            {
                Console.WriteLine("Purchase successful!");
            }
            else
            {
                Console.WriteLine("You cannot buy the prince.");
            }

            int level = 7;
            if (level >= 5)
            {
                Console.WriteLine("You have unlocked the door!");
            }
            else
            {
                Console.WriteLine("You need to reach level 5 to unlock the door.");
            }

            int score = 75;
            if (score >= 90)
            {
                Console.WriteLine("You got rank A!");
            }
            else if (score >= 80)
            {
                Console.WriteLine("You got rank B!");
            }
            else if (score >= 70)
            {
                Console.WriteLine("You got rank C!");
            }
            else if (score >= 60)
            {
                Console.WriteLine("You got rank D!");
            }
            else
            {
                Console.WriteLine("You got rank F!");
            }

            Console.Write("Your level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int key);

            if (!ok || key < 1 || key > 99)
            {
                Console.WriteLine("Invalid level.");
            }
            else if (key >= 10)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (key >= 20)
            {
                Console.WriteLine("The dungeon is unlocked.");
            }
            else if (key >= 30)
            {
                Console.WriteLine("The castle is unlocked.");
            }
            else if (key >= 40)
            {
                Console.WriteLine("The palace is unlocked.");
            }
            else if (key >= 50)
            {
                Console.WriteLine("The kingdom is unlocked.");
            }
            else if (key >= 60)
            {
                Console.WriteLine("The empire is unlocked.");
            }
            else if (key >= 70)
            {
                Console.WriteLine("The universe is unlocked.");
            }
            else if (key >= 80)
            {
                Console.WriteLine("The galaxy is unlocked.");
            }
            else if (key >= 90)
            {
                Console.WriteLine("The universe is unlocked.");
            }
            else
            {
                Console.WriteLine("The door is locked.");
            
            }
            */


            Console.WriteLine("HERO vs MONSTER ");
            Console.WriteLine();

            int heroHP;
            int monsterHP;
            int action;

            Console.Write("Enter Hero Hp (1-999): ");
            bool ok = int.TryParse(Console.ReadLine(), out heroHP);

            if (!ok || heroHP < 1 || heroHP > 999)
            {
                Console.WriteLine("Invalid Hero HP!.");
            }
            else
            {
                Console.Write("Enter Monster Hp (1-999): ");
                ok = int.TryParse(Console.ReadLine(), out monsterHP);

                if (!ok || monsterHP < 1 || monsterHP > 999)
                {
                    Console.WriteLine("Invalid Monster HP.");
                }
                else
                {
                    Console.WriteLine("Choose an action:");
                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Defend");
                    Console.WriteLine("3. Heal");

                    Console.Write("Enter Action (1-3): ");
                    ok = int.TryParse(Console.ReadLine(), out action);

                    if (!ok || action < 1 || action > 3)
                    {
                        Console.WriteLine("Invalid Action.");
                    }
                    else if (action == 1)
                    {
                        if (heroHP > monsterHP)
                        {
                            Console.WriteLine("Hero attacks and wins!");
                        }
                        else
                        {
                            Console.WriteLine("Hero attacks but loses!");
                        }
                    }
                    else if (action == 2)
                    {
                        if (heroHP >= monsterHP)
                        {
                            Console.WriteLine("Hero defends successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Hero defends but takes damage!");
                        }
                    }
                    else if (action == 3)
                    {
                        heroHP += 50;
                        Console.WriteLine("Hero heals and gains 50 HP!");
                        Console.WriteLine($"Hero HP: {heroHP}");
                    }
                }

            }
        }
    }
}
