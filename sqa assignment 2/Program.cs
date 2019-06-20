using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqa_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            do
            {
                while (true)
                {
                    Console.Write("\n\t1. press 1 get triangle type\n" +
                        "\t2.press for exit\n");
                 
                    if (!int.TryParse(Console.ReadLine(), out opt) || (opt > 2 || opt < 1))
                        Console.Write("\n\tInvalid Input\n\tplease enter again");
                    else
                        break;
                }
                switch (opt)
                {
                    case 1:
                        string side1, side2, side3;
                        int tside1 = 0, tside2 = 0, tside3 = 0;
                        while (true)
                        {
                            Console.Write("Enter side 1: ");
                            side1 = Console.ReadLine();
                            if (!int.TryParse(side1, out tside1) || (tside1 <= 0))
                                Console.Write("\n\tInvalid Input\n\tplease enter again");
                            else
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Enter side 2: ");
                            side2 = Console.ReadLine();
                            if (!int.TryParse(side2, out tside2) || (tside2 <= 0))
                                Console.Write("\n\tInvalid Input\n\tplease enter again");
                            else
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Enter side 3: ");
                            side3 = Console.ReadLine();
                            if (!int.TryParse(side3, out tside3) || (tside3 <= 0))
                                Console.Write("\n\tInvalid Input\n\tplease enter again");
                            else
                                break;
                        }
                        switch(triangle.Analyze(tside1, tside2, tside3))
                        {
                            case 1:
                                Console.WriteLine("Scalene");
                                break;
                            case 2:
                                Console.WriteLine("Isosceles");
                                break;
                            case 3:
                                Console.WriteLine("Equilateral");
                                break;
                            case 4:
                                Console.WriteLine("Invalid lenght given.");
                                break;
                        }
                        break;
                    case 2:
                          Console.WriteLine("Good bye");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Exception occured");
                        break;
                }
            } while (opt != 7);

        }
    }
}