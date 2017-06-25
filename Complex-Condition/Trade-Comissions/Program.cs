using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());
            var comission = -1.0;
            if (city == "sofia")
            {
                if(s>=0&&s<=500)
                {
                    comission = s * 0.05;
                }
                else
                {
                    if(s>500&&s<=1000)
                    {
                        comission = s * 0.07;
                    }
                    else
                    {
                        if(s>1000&&s<=10000)
                        {
                            comission =s* 0.08;
                        }
                        else
                        {
                            if(s>10000)
                            {
                                comission =s* 0.12;
                            }
                        }
                    }
                }
            }
            else
            {
                if(city=="varna")
                {
                    if (s >= 0 && s <= 500)
                    {
                        comission = s * 0.045;
                    }
                    else
                    {
                        if (s > 500 && s <= 1000)
                        {
                            comission = s * 0.075;
                        }
                        else
                        {
                            if (s > 1000 && s <= 10000)
                            {
                                comission = s * 0.10;
                            }
                            else
                            {
                                if (s > 10000)
                                {
                                    comission = s * 0.13;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if(city=="plovdiv")
                    {
                        if (s >= 0 && s <= 500)
                        {
                            comission = s * 0.055;
                        }
                        else
                        {
                            if (s > 500 && s <= 1000)
                            {
                                comission = s * 0.08;
                            }
                            else
                            {
                                if (s > 1000 && s <= 10000)
                                {
                                    comission = s * 0.12;
                                }
                                else
                                {
                                    if (s > 10000)
                                    {
                                        comission = s * 0.145;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if(comission>0)
            {
                Console.WriteLine("{0:f2}", comission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
