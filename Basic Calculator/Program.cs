using System;

namespace Basic_Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Start:
            Double num01;
            Double num02;
            Random numberGenerator = new Random();
            Random random = new Random();
            var num03 = numberGenerator.Next();
            var num04 = numberGenerator.Next();




            Console.Write("1. Random Numbers  2. Pick Your Own ");
            ConsoleKeyInfo result = Console.ReadKey();
            Console.WriteLine();


            if ((result.Key == ConsoleKey.D1))
            {
                int randomnumber = random.Next(0, 3);
                switch (randomnumber)
                {

                    case 0:

                        Console.Write(num03 + " + " + num04 + " = " + (num03 + num04));
                        goto yesno;

                    case 1:

                        Console.Write(num03 + " - " + num04 + " = " + (num03 - num04));
                        goto yesno;

                    case 2:

                        Console.Write(num03 + " * " + num04 + " = " + (num03 * num04));
                        goto yesno;

                    case 3:

                        Console.Write(num03 + " / " + num04 + " = " + (num03 / num04));
                        goto yesno;
                }

            }
            else if ((result.Key == ConsoleKey.D2))
            {
                Console.WriteLine();
                Console.Write("Type a number: ");
                num01 = Convert.ToDouble(Console.ReadLine());
                Console.Write("(1. Add) (2. Subtract) (3. Multiply) (4. Divide)  ");


                ConsoleKeyInfo result2 = Console.ReadKey();
                if ((result2.Key == ConsoleKey.D1))
                {
                    Console.WriteLine();
                    Console.Write("Type another number: ");
                    num02 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("The result is:  " + (num01 + num02));
                    Console.WriteLine();
                    goto yesno;
                }

                else if ((result2.Key == ConsoleKey.D2))
                {
                    Console.WriteLine();
                    Console.Write("Type another number:  ");
                    num02 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("The result is:  " + (num01 - num02));
                    goto yesno;
                }

                else if ((result2.Key == ConsoleKey.D3))
                {
                    Console.WriteLine();
                    Console.Write("Type another number:  ");
                    num02 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("The result is:  " + (num01 * num02));
                    goto yesno;
                }

                else if ((result2.Key == ConsoleKey.D4))
                {
                    Console.WriteLine();
                    Console.Write("Type another number:  ");
                    num02 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("The result is:  " + (num01 / num02));
                    Console.WriteLine();
                    goto yesno;
                }
            }

            yesno:

            Console.WriteLine();
            Console.Write("Again? (Y/N) ");
            ConsoleKeyInfo result3 = Console.ReadKey();
            if ((result3.Key == ConsoleKey.Y))
            {
                Console.WriteLine();
                Console.WriteLine();
                goto Start;

            }

            else if ((result3.Key == ConsoleKey.N))
            {
            }
        }
    }
}
