using HashingDataStructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashing hashing = new Hashing(5);

            while (true)
            {
                Console.WriteLine
                    ("Please select an option" +
                        Environment.NewLine + "1. Hash Chaining" +
                        Environment.NewLine + "2. Liner Probing" +
                        Environment.NewLine + "3. Quadratic Probing" +
                        Environment.NewLine + "4. Search in hash chaining" +
                        Environment.NewLine + "5. Search in Linear Probing" +
                        Environment.NewLine + "0. Exit"
                    );

                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine(Environment.NewLine + "Input format is not valid. Please try again." + Environment.NewLine);
                }

                if (i == 0)
                {
                    Environment.Exit(0);
                }
                else if (i == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if(num == -1)
                        {
                            break;
                        }

                        hashing.ChainingInsert(num);
                    }
                }
                else if (i == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == -1)
                        {
                            break;
                        }

                        if(!hashing.LinerInsert(num))
                        {
                            break;
                        }
                    }
                }
                else if (i == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == -1)
                        {
                            break;
                        }

                        if (!hashing.QuadraticInsert(num))
                        {
                            break;
                        }
                    }
                }
                else if (i == 4)
                {
                    Console.WriteLine("Enter the number");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(hashing.SearchChaining(num));
                }
                else if (i == 5)
                {
                    Console.WriteLine("Enter the number");
                    int num = Convert.ToInt32(Console.ReadLine());

                    int index = hashing.SearchLinearProbing(num);

                    if(index > -1)
                    {
                        Console.WriteLine("Key fount at index = " + index);
                    }
                    else
                        Console.WriteLine("Key not found");

                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }
            }
        }
    }
}
