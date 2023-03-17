using System;

namespace PlayerPerks
{
    class Program
    {
        enum PlayerPerks
        {
            WaterBreathing = 'w',
            Stealth = 's',
            AutoHeal = 'a',
            DoubleJump = 'd'
        }

        static void Main(string[] args)
        {
            
            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'w':
                        Console.WriteLine("WaterBreathing");
                        break;
                    case 's':
                
                        Console.WriteLine("Stealth");
                        break;
                    case 'a':
                        Console.WriteLine("AutoHeal");
                        break;
                    case 'd':
                        Console.WriteLine("DoubleJump");
                        break;
                    default:
                        Console.WriteLine("Invalid perk: " + c);
                        break;
                }
            }
        }
    }
}
