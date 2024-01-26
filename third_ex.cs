using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_algs_first
{
    internal class third_ex
    {
        public void push()
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            //string[] h = Console.ReadLine().Split(' ');
            //int[] spisok = new int[h.Length];
            //for (int i = 0; i < spisok.Length; i++)
            //{
            //    int.TryParse(h[i], out spisok[i]);
            //}
            int[] spisok = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double up = spisok.Max();
            double S;
            while (true)
            {
                S = 0;
                for (int i = 0; i < spisok.Length - 1; i++)
                {
                    if (spisok[i] == spisok[i + 1])
                    {
                        if (spisok[i] > up)
                        {
                            S -= (spisok[i] - up);
                        }
                        if (spisok[i] < up)
                        {
                            S += (up - spisok[i]);
                        }
                    }
                    if (spisok[i] > spisok[i + 1])
                    {
                        if (spisok[i] > up && spisok[i + 1] < up)
                        {
                            S += ((spisok[i] - spisok[i + 1]) / 2.0) * Math.Pow(((up - spisok[i + 1]) / ((spisok[i] - spisok[i + 1]))), 2);
                            S -= ((spisok[i] - spisok[i + 1]) / 2.0) * Math.Pow(((spisok[i] - up) / ((spisok[i] - spisok[i + 1]))), 2);
                        }
                        if (spisok[i] <= up)
                        {
                            S += (up - spisok[i]) + ((spisok[i] - spisok[i + 1]) / 2.0);
                        }
                        if (spisok[i + 1] >= up)
                        {
                            S -= (spisok[i + 1] - up) + ((spisok[i] - spisok[i + 1]) / 2.0);
                        }
                    }
                    if (spisok[i] < spisok[i + 1])
                    {
                        if (spisok[i + 1] > up && spisok[i] < up)
                        {
                            S += ((spisok[i + 1] - spisok[i]) / 2.0) * Math.Pow(((up - spisok[i]) / ((spisok[i + 1] - spisok[i]))), 2);
                            S -= ((spisok[i + 1] - spisok[i]) / 2.0) * Math.Pow(((spisok[i + 1] - up) / ((spisok[i + 1] - spisok[i]))), 2);
                        }
                        if (spisok[i + 1] <= up)
                        {
                            S += (up - spisok[i + 1]) + ((spisok[i + 1] - spisok[i]) / 2.0);
                        }
                        if (spisok[i] >= up)
                        {
                            S -= (spisok[i] - up) + ((spisok[i + 1] - spisok[i]) / 2.0);
                        }
                    }
                }
                if (Math.Abs(S - 0) <= 1e-4)
                {
                    //Console.WriteLine(S);
                    break;
                }
                up -= 1e-4;
                up = Math.Round(up, 4);

            }
            Console.WriteLine(up);

        }
    }
}
