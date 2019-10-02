using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsSpockLizard
{
    public class Game
    {
        public Dictionary<int, string> figures;

        public void Run()
        {
            GenerateFigures();

            while(true)
            {
                Show();
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("Thank you for your game!");
                    break;
                }
                Console.Write("You are ");
                Console.WriteLine(figures[number]);
                Random rand = new Random();
                int opponent = rand.Next(1, 6);
                Console.Write("Your opponent is ");
                Console.WriteLine(figures[opponent]);
                int k = 0;

                if (number == 1)
                {
                    if(opponent == 3 || opponent == 5)
                    {
                        k = 1;
                    }
                    else if (opponent == 2 || opponent == 4)
                    {
                        k = 2;
                    }
                    else
                    {
                        k = 3;
                    }
                }
                else if (number == 2)
                {
                    if (opponent == 1|| opponent == 4)
                    {
                        k = 1;
                    }
                    else if (opponent == 3 || opponent == 5)
                    {
                        k = 2;
                    }
                    else
                    {
                        k = 3;
                    }
                }
                else if (number == 3)
                {
                    if (opponent == 2 || opponent == 5)
                    {
                        k = 1;
                    }
                    else if (opponent == 1 || opponent == 4)
                    {
                        k = 2;
                    }
                    else
                    {
                        k = 3;
                    }
                }
                else if (number == 4)
                {
                    if (opponent == 1 || opponent == 3)
                    {
                        k = 1;
                    }
                    else if (opponent == 2 || opponent == 5)
                    {
                        k = 2;
                    }
                    else
                    {
                        k = 3;
                    }
                }
                else if (number == 5)
                {
                    if (opponent == 4 || opponent == 2)
                    {
                        k = 1;
                    }
                    else if (opponent == 1 || opponent == 3)
                    {
                        k = 2;
                    }
                    else
                    {
                        k = 3;
                    }
                }
                else
                {
                    k = 3;
                }

                if(k == 1)
                {
                    Console.WriteLine("You are the winner!");
                }
                else if (k == 2)
                {
                    Console.WriteLine("Sorry, you are loser :(");
                }
                else
                {
                    Console.WriteLine("It's a draw. Let's try again");
                }



            }


        }

        public void Show()
        {
            Console.WriteLine("Choose your figure by entering number:");
            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - Rock");
            Console.WriteLine("2 - Paper");
            Console.WriteLine("3 - Scissors");
            Console.WriteLine("4 - Spock");
            Console.WriteLine("5 - Lizard");
        }

        public void GenerateFigures()
        {
            figures = new Dictionary<int, string>(5);
            figures.Add(1, "Rock");
            figures.Add(2, "Paper");
            figures.Add(3, "Scissors");
            figures.Add(4, "Spock");
            figures.Add(5, "Lizard");
        }
        
    }
}
