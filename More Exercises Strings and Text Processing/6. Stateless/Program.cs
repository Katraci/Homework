using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            while (text != "collapse")
            {
                string seekAndDelete = Console.ReadLine();
                while (seekAndDelete.Length != 0)
                {
                    int index = 0;
                    do
                    {
                        index = text.IndexOf(seekAndDelete, index);
                        if (index>=0)
                        {
                            text = text.Remove(index, seekAndDelete.Length);
                        }
                        if (seekAndDelete==text)
                        {
                            text = "";
                            break;
                        }

                    } while (index >= 0);
                    if (text.Length==0)
                    {
                        break;
                    }
                    if (seekAndDelete.Length == 1)
                    {
                        break;
                    }
                    else
                    {
                        seekAndDelete = seekAndDelete.Substring(1, seekAndDelete.Length - 2);
                    }
                }
                if (text.Length==0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(text);
                }
                text = Console.ReadLine();
            }
        }
    }
}
