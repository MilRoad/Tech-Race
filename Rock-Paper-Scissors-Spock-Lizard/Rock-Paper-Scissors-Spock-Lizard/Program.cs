using System;

namespace RockPaperScissorsSpockLizard
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game RPSSL = new Game();
            RPSSL.Run();

            Console.ReadKey();
        }
    }
}
