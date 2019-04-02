using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Vnesete N"); 
            N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Za sluchajno generiranje vnesete 1,a za samostojno vnesuvanje vnesete 2");
            if ((Convert.ToInt64(Console.ReadLine())) == 1)
            {
                Random random = new Random();
                int[] niza = new int[N];
                for (int i = 0; i < N; i++)
                {
                    
                    niza[i] = random.Next(1, 1000);
                }
                Console.WriteLine(niza.Average());
                Console.WriteLine(niza.Max());
                Console.WriteLine(niza.Min());
                Console.ReadKey();
            }
            else if((Convert.ToInt64(Console.ReadLine())) == 2)
            {
                
                int[] niza = new int[N];
                for (int i = 0; i < N; i++)
                {
                   
                    niza[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine(niza.Average());
                Console.WriteLine(niza.Max());
                Console.WriteLine(niza.Min());
                Console.ReadKey();
                else{
                    Console.WriteLine("Vnesete 1 ili 2");
                }
            }
        }
    }
}
