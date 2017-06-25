using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smal_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(0.5 * quantity);
                }
                else
                {
                    if (city == "varna")
                    {
                        Console.WriteLine(0.45 * quantity);
                    }
                    else
                    {
                        Console.WriteLine(0.4 * quantity);
                    }
                }
            }
            else
            {
                if (product == "water")
                {
                    if (city == "sofia")
                    {
                        Console.WriteLine(0.8 * quantity);
                    }
                    else
                    {
                        if (city == "varna")
                        {
                            Console.WriteLine(0.7 * quantity);
                        }
                        else
                        {
                            Console.WriteLine(0.7 * quantity);
                        }
                    }
                }
                else
                {
                    if (product == "beer")
                    {
                        if (city == "sofia")
                        {
                            Console.WriteLine(1.2 * quantity);
                        }
                        else
                        {
                            if (city == "varna")
                            {
                                Console.WriteLine(1.1 * quantity);
                            }
                            else
                            {
                                Console.WriteLine(1.15 * quantity);
                            }
                        }

                    }
                    else
                    {
                        if (product == "sweets")
                        {
                            if (city == "sofia")
                            {
                                Console.WriteLine(1.45 * quantity);
                            }
                            else
                            {
                                if (city == "varna")
                                {
                                    Console.WriteLine(1.35 * quantity);
                                }
                                else
                                {
                                    Console.WriteLine(1.30 * quantity);
                                }
                            }
                        }
                        else
                        {
                            if (city == "sofia")
                            {
                                Console.WriteLine(1.6 * quantity);
                            }
                            else
                            {
                                if (city == "varna")
                                {
                                    Console.WriteLine(1.55 * quantity);
                                }
                                else
                                {
                                    Console.WriteLine(1.5 * quantity);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

