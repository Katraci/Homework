using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int rounds = int.Parse(Console.ReadLine());
            do
            {
                for (int i = 1; i <= rounds; i++)
                {
                    for (int j = 0; j < grapes.Count; j++)
                    {
                        if (j == 0)
                        {
                            if (!GreatGrape(grapes, (j + 1))&&grapes[j]!=0)
                            {
                                grapes[j]++;
                            }
                            continue;
                        }
                        if (j == grapes.Count - 1)
                        {
                            if (!GreatGrape(grapes, (j - 1)) && grapes[j] != 0)
                            {
                                grapes[j]++;
                            }
                            continue;
                        }
                        if (GreatGrape(grapes, j))
                        {
                            if (grapes[j - 1] != 0)
                            {
                                grapes[j]++;
                                grapes[j - 1]--;
                            }
                            grapes[j]++;
                            if (grapes[j + 1] != 0)
                            {
                                grapes[j]++;
                                grapes[j + 1]--;
                            }
                        }
                        else
                        {
                            if (!LowerGrape(grapes, j))
                            {
                                grapes[j]++;
                            }
                        }

                    }
                }
                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= rounds)
                    {
                        grapes[i] = 0;
                    }
                }

            }
            while (DeadGrape(grapes,rounds) >= rounds);
            grapes.RemoveAll(a => a <= rounds);
            Console.WriteLine(string.Join(" ", grapes));
        }

        static bool LowerGrape(List<int> grapes, int j)
        {
            bool lower = false;
            if (j == 1)
            {
                if (GreatGrape(grapes, j + 1))
                {
                    lower = true;
                }
            }
            else
            {
                if (j == grapes.Count - 2)
                {
                    if (GreatGrape(grapes, j - 1))
                    {
                        lower = true;
                    }
                }
                else
                {
                    if (GreatGrape(grapes, j - 1) || GreatGrape(grapes, j + 1)||(GreatGrape(grapes, j - 1) && GreatGrape(grapes, j + 1)))
                    {
                        lower = true;
                    }
                }
            }
            return lower;
        }


        static bool GreatGrape(List<int> grapes, int n)
        {
            bool great = false;

            if ((grapes[n] > grapes[n - 1]) && (grapes[n] > grapes[n + 1]))
            {
                great = true;
            }
            return great;
        }

        static int DeadGrape(List<int> grapes,int n)
        {
            int dead = 0;
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <=n)
                {
                    dead++;
                }
            }
            return grapes.Count-dead;
        }
    }
}
