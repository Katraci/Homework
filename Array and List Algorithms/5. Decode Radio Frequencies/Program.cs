using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            List<int> numbersBegin = new List<int>();
            List<int> numbersEnd = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int[] arrHelp = arr[i].ToString().Split('.').Select(int.Parse).ToArray();
                if (arrHelp[0] > 0)
                {
                    numbersBegin.Add(arrHelp[0]);
                }
                if (arrHelp.Length==2)
                {
                    numbersEnd.Add(arrHelp[1]);
                }
            }
            for (int i = numbersEnd.Count-1; i >=0; i--)
            {
                numbersBegin.Add(numbersEnd[i]);
            }
            for (int i = 0; i < numbersBegin.Count; i++)
            {
                char curent = (char)numbersBegin[i];
                Console.Write(curent);
            }
            Console.WriteLine();

        }

    }
}
