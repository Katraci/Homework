using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());
            string sms = "";
            for (int i = 1; i <=letters; i++)
            {
                string curentLeter = Console.ReadLine();
                if (curentLeter.EndsWith("2"))
                {
                    char current = (char)((curentLeter.Length - 1)+'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("3"))
                {
                    char current = (char)(3 + (curentLeter.Length - 1) + 'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("4"))
                {
                    char current = (char)(6 + (curentLeter.Length - 1) + 'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("5"))
                {
                    char current = (char)(9 + (curentLeter.Length - 1) + 'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("6"))
                {
                    char current = (char)(12 + (curentLeter.Length - 1) + 'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("7"))
                {
                    char current = (char)(15+ (curentLeter.Length - 1) + 'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("8"))
                {
                    char current = (char)(19+ (curentLeter.Length - 1) + 'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("9"))
                {
                    char current = (char)(22 + (curentLeter.Length - 1) + 'a');
                    sms += current;
                }
                if (curentLeter.EndsWith("0"))
                {
                    sms += " ";
                }
                
            }
            Console.WriteLine(sms);
        }
    }
}
