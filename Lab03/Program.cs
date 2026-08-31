/*
 * Student ID : 1690700677
 * Name       : Witawat Thawon
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nName: {bossName}\nRank: {rank}\nlevel: {level} / {MaxLevel}\nHp: {currentHp} / {maxHp}" +
                $"\nAttackPower: {attackPower}\nCritMultiplier: {critMultiplier}\nIsBoss: {isBoss}");
            Console.WriteLine();
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double CurrentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {CurrentHpDouble}");
            Console.WriteLine();
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = CurrentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int ----");
            int attackInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackInt}");
            Console.WriteLine();
            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);

            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
