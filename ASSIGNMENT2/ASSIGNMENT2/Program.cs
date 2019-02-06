using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    class Program
    {
        static void Main(string[] args)
        {
            string MenuSelection = string.Empty;
            string AT= string.Empty;
            do
            {
                Console.WriteLine("1. enter dimensions of the triangle");
                Console.WriteLine("2. exit\n");
                MenuSelection = Console.ReadLine();
                if (!MenuSelection.Equals("1") && !MenuSelection.Equals("2"))
                {

                    Console.Write("invalid input,enter a valid input \n");

                }

                else if (MenuSelection.Equals("1"))
                {
                    int S1 = 0, S2 = 0, S3 = 0;

                    bool isValid = false;

                    do
                    {
                        isValid = false;
                        Console.WriteLine("enter S1 ");
                        isValid = int.TryParse(Console.ReadLine(), out S1);
                        if (!isValid || S1 <= 0)
                        {
                            Console.Write(" dimension of S1 is invalid \n");
                        }
                    }
                    while (!isValid || S1 <= 0);
                    do
                    {
                        isValid = false;
                        Console.WriteLine("enter S2 ");
                        isValid = int.TryParse(Console.ReadLine(), out S2);
                        if (!isValid || S2 <= 0)
                        {
                            Console.Write(" dimension of S2 is invalid \n");
                        }
                    }

                    while (!isValid || S2 <= 0);

                    do
                    {
                        isValid = false;
                        Console.WriteLine("enter S3 ");
                        isValid = int.TryParse(Console.ReadLine(), out S3);
                        if (!isValid || S3 <= 0)
                        {
                            Console.Write(" dimension of S3 is invalid \n");
                        }
                    }

                    while (!isValid || S3 <= 0);

                    AT= Trianglesolver.analyze(S1, S2, S3);
                    Console.WriteLine(AT);

                }
            }

            while (MenuSelection != "2");
        }

            }
        }
