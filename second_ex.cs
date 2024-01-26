using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_algs_first
{
    internal class second_ex
    {
        public void push()
        {
            //string a = Console.ReadLine();
            int min = -1;
            int max = 0;
            int counter = 0;
            string[] text = Console.ReadLine().Split('#');
            for (int i = 0; i < text.Length; i++)
            {
                if ((min == -1 || min > 0) && max != 0)
                {
                    if (counter == 1)
                    {
                        min = max;
                    }
                    if (max < text[i].Length)
                    {
                        min = max;
                    }
                }
                if (max < text[i].Length)
                {
                    max = text[i].Length;
                    counter++;
                }
                if (text[i] == "")
                {
                    min = 0;
                    continue;
                }
            }
            Console.WriteLine($"{min} {max}");
        }
    }
}
