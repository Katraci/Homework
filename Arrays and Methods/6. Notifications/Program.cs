using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberEnteres = int.Parse(Console.ReadLine().ToLower());
            for (int i = 1; i <= numberEnteres; i++)
            {
                string result = Console.ReadLine();
                if (result== "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                if (result== "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }

            }
        }

        private static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            if (code>0)
            Console.WriteLine("Reason: Invalid Client Data.");
            else
            Console.WriteLine("Reason: Internal System Failure.");
        }

        private static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }
    }
}
