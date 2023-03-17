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
                if (!Enum.IsDefined(typeof(PlayerPerks), (int)c))
                {
                    Console.WriteLine("Unknown perk: " + c);
                    
                    break;
                }
                else 
                {
                    switch (c)
                    {
                        case 'w':
                            Console.WriteLine("WaterBreathing");
                            break;
                        case 'a':
                            Console.WriteLine("AutoHeal");
                            break;
                        case 's':
                            Console.WriteLine("Stealth");
                            break;
                        case 'd':
                            Console.WriteLine("DoubleJump");
                            break;
                    }
                }
                
            }
        }
    }
}



