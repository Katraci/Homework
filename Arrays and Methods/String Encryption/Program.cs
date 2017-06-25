using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= lines; i++)
            {
                string letter = Console.ReadLine();
                char curentLetter = Convert.ToChar(letter);
                result += Encrypt(curentLetter);
            }
            Console.WriteLine(result);
        }

        static string Encrypt(char letter)
        {
            string result = "";
            int letterInteger = (int)letter;
            char lowerLeter = (char)(letterInteger-GetFrontNumber(letterInteger));
            char greaterLetter= (char)(letterInteger + GetBackNumber(letterInteger));
            result= greaterLetter + GetFrontNumber(letterInteger).ToString()
                + GetBackNumber(letterInteger).ToString() + lowerLeter;
            return result;
        }

        static int GetBackNumber(int number)
        {
            int backNumber;
            if (number < 100)
            {
                backNumber = number % 10;
            }
            else
            {
                backNumber = number % 100;
                backNumber = backNumber % 10;
            }
            return backNumber;
        }

        static int GetFrontNumber(int number)
        {
            int frontNumber;
            if (number<100)
            {
                frontNumber = number / 10;
            }
            else
            {
                frontNumber = number / 100;
            }
            return frontNumber;
        }
    }
}
