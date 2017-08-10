using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string happyFilter = @"((:\))|(:D)|(;\))|(:\*)|(:\])|(;])|(:})|(;})|(\(:)|(\*:)|(c:)|(\[:)|(\[;))";
            string sadFilter = @"((\:\()|(D\:)|(\;\()|(\:\[)|(\;\[)|(\:\{)|(\;\{)|(\)\:)|(\:c)|(\]\:)|(\]\;))";
            MatchCollection happy = new Regex(happyFilter).Matches(input);
            MatchCollection sad = new Regex(sadFilter).Matches(input);
            double happyIndex = (double)happy.Count / sad.Count;
            if (happyIndex<1)
            {
                Console.WriteLine($"Happiness index: {happyIndex:f2} :(");
            }
            if (happyIndex==1.0)
            {
                Console.WriteLine($"Happiness index: {happyIndex:f2} :|");
            }
            if (happyIndex>1&&happyIndex<2)
            {
                Console.WriteLine($"Happiness index: {happyIndex:f2} :)");
            }
            if (happyIndex>=2.0)
            {
                Console.WriteLine($"Happiness index: {happyIndex:f2} :D");
            }
            Console.WriteLine($"[Happy count: {happy.Count}, Sad count: {sad.Count}]");
        }
    }
}
