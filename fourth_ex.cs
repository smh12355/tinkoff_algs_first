using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_algs_first
{
    internal class fourth_ex
    {
        public void push()
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            //string[] h = Console.ReadLine().Split(' ');
            int[] spisok = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] spisok = new int[h.Length];
            //for (int i = 0; i < spisok.Length; i++)
            //{
            //    int.TryParse(h[i], out spisok[i]);
            //}
            Array.Sort(spisok);
            int counter = 0;
            for (int i = 0; i < spisok.Length; i++)
            {
                if (i != spisok.Length - 1 && spisok[i + 1] - spisok[i] == 1)
                {
                    counter++;
                }
                else
                {
                    if (counter >= 2)
                    {
                        for (int j = 1; j < counter; j++)
                        {
                            spisok[i - j] = -1;
                        }
                        counter = 0;
                    }
                }

            }
            for (int i = 0; i < spisok.Length; i++)
            {
                if (spisok[i] == -1)
                {
                    if (i != spisok.Length - 1 && spisok[i + 1] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write("... ");
                    }
                }
                else
                {
                    Console.Write($"{spisok[i]} ");
                }
            }
        }
    }
}

