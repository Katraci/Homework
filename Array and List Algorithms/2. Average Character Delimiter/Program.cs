using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            char forDelimited = new char();
            int sum = 0;
            int divid = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += GetSumOfString(arr[i]);
                divid += GetDivid(arr[i]);
            }
            forDelimited =(char) (sum / divid);
            Console.WriteLine(string.Join(forDelimited.ToString().ToUpper(), arr));
        }

        private static int GetDivid(string v)
        {
            char[] helpingArr = v.ToCharArray();
            int divid = helpingArr.Length;
            return divid;
        }

        private static int GetSumOfString(string v)
        {
            int sum = 0;
            char[] helpingArr = v.ToCharArray();
            for (int i = 0; i < helpingArr.Length; i++)
            {
                sum += helpingArr[i];
            }
            return sum;
        }
    }
}
