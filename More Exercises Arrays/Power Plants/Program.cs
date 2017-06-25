using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] powerLevel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long days = 0;
            long seasons = 0;
            while (CheckArray(powerLevel) != 0)
            {
                
                for (int i = 0; i < powerLevel.Length; i++)
                {
                    days++;
                  
                    for (int j = 0; j < powerLevel.Length; j++)
                    {
                        
                        if (i != j)
                        {
                            powerLevel[j]--;
                            if (powerLevel[j] < 0)
                            {
                                powerLevel[j] = 0;
                            }
                        }
                        if (CheckArray(powerLevel) == 0)
                        {
                            break;
                        }

                    }
                    if (CheckArray(powerLevel) == 0)
                    {
                        break;
                    }
                    
                }
              
                if (CheckArray(powerLevel) == 0)
                {
                    break;
                }
                else
                {
                    for (int k = 0; k < powerLevel.Length; k++)
                    {
                        if (powerLevel[k] != 0)
                        {
                            powerLevel[k]++;
                        }
                    }
                }
                seasons++;
            }
            if (seasons == 1)
            {
                Console.WriteLine($"survived {days} days ({seasons} season)");
            }
            else
            {
                Console.WriteLine($"survived {days} days ({seasons} seasons)");
            }
        }

        static int CheckArray(int[] powerLevel)
        {
            int zeroEquans = 0;
            for (int i = 0; i < powerLevel.Length; i++)
            {
                zeroEquans += powerLevel[i];
            }
            return zeroEquans;
        }
    }
}
