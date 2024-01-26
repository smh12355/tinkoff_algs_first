using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_algs_first
{
    internal class first_ex
    {
        public void push()
        {
            //for test push
            //for testing branch
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //string[] coord1 = Console.ReadLine().Split(' ');
            //string[] coord2 = Console.ReadLine().Split(' ');
            //string[] coord3 = Console.ReadLine().Split(' ');
            double[] container = Console.ReadLine().Split(' ').Select(double.Parse).ToArray()
            .Concat(Console.ReadLine().Split(' ').Select(double.Parse).ToArray())
            .Concat(Console.ReadLine().Split(' ').Select(double.Parse).ToArray()).ToArray();
            int counter = 0;
            for (int i = 0; i < 6; i+=2)
            {
                switch (Math.Sqrt(Math.Pow(container[i], 2) + Math.Pow(container[i+1], 2)))
                {
                    case double q when q <= 0.1:
                        counter += 3;
                        break;
                    case double q when 0.1 < q && q <= 0.8:
                        counter += 2;
                        break;
                    case double q when 0.8 < q && q <= 1:
                        counter += 1;
                        break;
                    case double q when q > 1:
                        break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
