using System;
using System.Linq;


namespace _7.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="end")
            {
                string clear=new string(input.ToCharArray().Where(c=> (char.IsLetterOrDigit(c)
                                  || char.IsWhiteSpace(c)
                                  || c == '\'')).ToArray());
                string[] words = clear.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i].ToLower();
                    string first = word[0].ToString();
                    string changeWith = first.ToUpper();
                    words[i] = changeWith+word.Remove(0,1);
                }
                Console.WriteLine(string.Join(", ",words));
                input = Console.ReadLine();
            }
        }
    }
}
