using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.String_Commander
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] curentCommand = input.Split(' ').ToArray();
                string comand = curentCommand[0];
                switch (comand)
                {
                    case "Left":text = MoveToLeft(text,int.Parse(curentCommand[1]));
                        break;
                    case "Right":text= MoveToRight(text, int.Parse(curentCommand[1]));
                        break;
                    case "Insert":text = InsertText(text, int.Parse(curentCommand[1]), curentCommand[2]);
                        break;
                    case "Delete":text = DeleteText(text, int.Parse(curentCommand[1]), int.Parse(curentCommand[2]));
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(text);
        }

        private static string DeleteText(string text, int v1, int v2)
        {
            return text.Remove(v1, v2+1-v1);
        }

        private static string InsertText(string text, int v1, string v2)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                result.Append(text[i]);
            }
            result.Insert(v1, v2);
      
            return result.ToString();
        }

        private static string MoveToRight(string text, int v)
        {
            string result = text;
            v = v % text.Length;
            if (v!= text.Length || v != 0)
            {
                int counter = text.Length - v;
                result = text.Substring(counter, text.Length - counter);
                string token = text.Substring(0, counter);
                result += token;
            }
            
            return result;
        }

        private static string MoveToLeft(string text, int n)
        {
            string result = text;
            n = n % text.Length;
            if (n!= text.Length||n!=0)
            {

                result = text.Substring(n, text.Length - n);
                string token = text.Substring(0, n);
                result += token;
            }
            
            return result;
        }
    }
}
