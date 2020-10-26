using System;

namespace CardSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 50);
            Console.Title = "Card Sort";
            DealCards dc = new DealCards();
            bool quit = false;

            while (!quit)
            {
                dc.Deal();

                char selection = ' ';
                while (!selection.Equals('Y')  && !selection.Equals('N'))
                {
                    Console.WriteLine("Deal again? Y or N");
                    selection = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (selection.Equals('Y'))
                        quit = false;
                    else if (selection.Equals('N'))
                        quit = true;
                    else
                        Console.WriteLine("Invalid input");
                }
            }

            Console.ReadKey();
        }
    }
}
