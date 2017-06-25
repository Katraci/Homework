using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 1; i <=lines; i++)
            {
                int number= int.Parse(Console.ReadLine());
                if (number>999)
                {
                    Console.WriteLine("too large");
                }
                else
                {
                    if (number<-999)
                    {
                        Console.WriteLine("too small");
                    }
                    else
                    {
                        if (number>99||number<-99)
                        {
                            string result = IntToString(number);
                            if (number > 0)
                            {
                                Console.WriteLine(result);
                            }
                            else
                            {
                                Console.WriteLine($"minus {result}");
                            }
                        }
                    }
                }
            }
        }

        static string IntToString(int number)
        {
            if (number < 0)
            {
                number = number * -1;
            }
            string result = "";
            if (number % 100 != 0)
            {
                if (number % 100>10)
                {
                    result = TransformNumberLowerThanTen(number / 100) + "-hundred and "
                    + TransformNumberGreterThanTen(number % 100);
                }
                else
                {
                    result = TransformNumberLowerThanTen(number / 100) + "-hundred and "
                   + TransformNumberLowerThanTen(number % 100);
                }
                
            }
            else
            {
                result = TransformNumberLowerThanTen(number / 100) + "-hundred";
            }
                return result;
        }

        static string TransformNumberGreterThanTen(int v)
        {
            string numberInString = "";
            if (v<20)
            {
                numberInString = TransformNumberLowerThanTwenty(v);
            }
            else
            {
                if (v % 10!=0)
                {
                    numberInString = TransformNumberGreaterThanTwenty(v / 10) 
                        + " " + TransformNumberLowerThanTen(v % 10);
                }
                else
                {
                    numberInString = TransformNumberGreaterThanTwenty(v / 10);
                }
                }
            return numberInString;
        }

        private static string TransformNumberGreaterThanTwenty(int v)
        {
            string numberInString = "";
            switch (v)
            {
                case 2: numberInString = "twenty"; break;
                case 3: numberInString = "thirty"; break;
                case 4: numberInString = "forty"; break;
                case 5: numberInString = "fifty"; break;
                case 6: numberInString = "sixty"; break;
                case 7: numberInString = "seventy"; break;
                case 8: numberInString = "eighty "; break;
                case 9: numberInString = "ninety"; break;
                default:
                    break;
            }
            return numberInString;
        }

        static string TransformNumberLowerThanTwenty(int v)
        {
            string numberInString = "";
            switch (v)
            {
                case 10: numberInString = "ten"; break;
                case 11: numberInString = "eleven"; break;
                case 12: numberInString = "twelve"; break;
                case 13: numberInString = "thirteen"; break;
                case 14: numberInString = "fourteen"; break;
                case 15: numberInString = "fifteen"; break;
                case 16: numberInString = "sixteen"; break;
                case 17: numberInString = "seventeen"; break;
                case 18: numberInString = "eighteen"; break;
                case 19: numberInString = "nineteen"; break;
                default:
                    break;
            }
            return numberInString;
        }

        static string TransformNumberLowerThanTen(int v)
        {
            string numberInString = "";
            switch (v)
            {
                case 1:numberInString = "one";break;
                case 2: numberInString = "two"; break;
                case 3: numberInString = "three"; break;
                case 4: numberInString = "four"; break;
                case 5: numberInString = "five"; break;
                case 6: numberInString = "six"; break;
                case 7: numberInString = "seven"; break;
                case 8: numberInString = "eight"; break;
                case 9: numberInString = "nine"; break;
                default:
                    break;
            }
            return numberInString;
        }
    }
}
