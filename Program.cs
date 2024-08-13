using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a minimum value");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the maximum value");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the interval value");
            int interval = int.Parse(Console.ReadLine());

            if((max - min) % interval != 0)
            {
                Console.WriteLine("Invalid interval");
                Console.ReadLine();
                
            }
            else
            {
                int n=(max- min) / interval;
                int i =1;
                int sum =0;

                for ( i = 1; i<=n; i++)
                {
                    sum = sum +min;
                    min = min+interval;
                    
                }
                Console.WriteLine("sum of the interval:" + sum);
                Console.WriteLine("minimum of the interval:" + min);
                Console.ReadLine();
            }
        }
    }
}
