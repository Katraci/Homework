using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string[] curentCallMessage = new string [2];
            while (curentCallMessage[0] != "done")
            {
                curentCallMessage = Console.ReadLine().Split(' ');
                for (int i = 0; i < names.Length; i++)
                {
                    if (curentCallMessage[0] == "message")
                    {
                        if (curentCallMessage[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                            int difference = DifferenceNumber(phoneNumbers[i]);
                            PrintMessage(difference);
                        }
                        if (curentCallMessage[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                            int difference = DifferenceNumber(phoneNumbers[i]);
                            PrintMessage(difference);
                        }
                    }

                    if (curentCallMessage[0]=="call")
                    {
                        if (curentCallMessage[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");
                            int sum = SumNumber(phoneNumbers[i]);
                            PrintCall(sum);
                        }
                        if (curentCallMessage[1] == names[i])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                            int sum = SumNumber(phoneNumbers[i]);
                            PrintCall(sum);
                        }
                    }
                }
            }
        }

        static void PrintCall(int sum)
        {
            if (sum % 2 == 0)
            {
                Console.WriteLine($"call ended. duration: {sum/60:D2}:{sum % 60:D2}");
            }
            else
            {
                Console.WriteLine("no answer");
            }
        }

        static void PrintMessage(int difference)
        {
            if (difference%2==0)
            {
                Console.WriteLine("meet me there");
            }
            else
            {
                Console.WriteLine("busy");
            }
        }

        static int DifferenceNumber(string v)
        {
            int difference = 0;
            char[] token = v.ToCharArray();
            for (int i = 0; i < token.Length; i++)
            {
                switch (token[i])
                {
                    case '1': difference -= 1;break;
                    case '2': difference -= 2; break;
                    case '3': difference -= 3; break;
                    case '4': difference -= 4; break;
                    case '5': difference -= 5; break;
                    case '6': difference -= 6; break;
                    case '7': difference -= 7; break;
                    case '8': difference -= 8; break;
                    case '9': difference -= 9; break;
                    default:
                        break;
                }
            }

            return difference ;
        }
        static int SumNumber(string v)
        {
            int sum = 0;
            char[] token = v.ToCharArray();
            for (int i = 0; i < token.Length; i++)
            {
                switch (token[i])
                {
                    case '1': sum += 1; break;
                    case '2': sum += 2; break;
                    case '3': sum += 3; break;
                    case '4': sum += 4; break;
                    case '5': sum += 5; break;
                    case '6': sum += 6; break;
                    case '7': sum += 7; break;
                    case '8': sum += 8; break;
                    case '9': sum += 9; break;
                    default:
                        break;
                }
            }

            return sum;
        }
    }
}
