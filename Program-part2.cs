using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aocd6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            Part2();
            Console.ReadLine();
        }

        static public void Part1()
        {
            List<long> fishes = new List<long>() { 3, 4, 3, 1, 2 };
            for (int days = 0; days < 80; days++)
            {
                for (int i = 0; i < fishes.Count; i++)
                {
                    fishes[i]--;
                    if (fishes[i] == -1)
                    {
                        fishes[i] = 6;
                        fishes.Add(9);
                    }
                    Console.Write(fishes[i] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine(fishes.Count);
        }
        static public void Part2()
        {
            var input = "3, 5, 1, 5, 3, 2, 1, 3, 4, 2, 5, 1, 3, 3, 2, 5, 1, 3, 1, 5, 5, 1, 1, 1, 2, 4, 1, 4, 5, 2, 1, 2, 4, 3, 1, 2, 3, 4, 3, 4, 4, 5, 1, 1, 1, 1, 5, 5, 3, 4, 4, 4, 5, 3, 4, 1, 4, 3, 3, 2, 1, 1, 3, 3, 3, 2, 1, 3, 5, 2, 3, 4, 2, 5, 4, 5, 4, 4, 2, 2, 3, 3, 3, 3, 5, 4, 2, 3, 1, 2, 1, 1, 2, 2, 5, 1, 1, 4, 1, 5, 3, 2, 1, 4, 1, 5, 1, 4, 5, 2, 1, 1, 1, 4, 5, 4, 2, 4, 5, 4, 2, 4, 4, 1, 1, 2, 2, 1, 1, 2, 3, 3, 2, 5, 2, 1, 1, 2, 1, 1, 1, 3, 2, 3, 1, 5, 4, 5, 3, 3, 2, 1, 1, 1, 3, 5, 1, 1, 4, 4, 5, 4, 3, 3, 3, 3, 2, 4, 5, 2, 1, 1, 1, 4, 2, 4, 2, 2, 5, 5, 5, 4, 1, 1, 5, 1, 5, 2, 1, 3, 3, 2, 5, 2, 1, 2, 4, 3, 3, 1, 5, 4, 1, 1, 1, 4, 2, 5, 5, 4, 4, 3, 4, 3, 1, 5, 5, 2, 5, 4, 2, 3, 4, 1, 1, 4, 4, 3, 4, 1, 3, 4, 1, 1, 4, 3, 2, 2, 5, 3, 1, 4, 4, 4, 1, 3, 4, 3, 1, 5, 3, 3, 5, 5, 4, 4, 1, 2, 4, 2, 2, 3, 1, 1, 4, 5, 3, 1, 1, 1, 1, 3, 5, 4, 1, 1, 2, 1, 1, 2, 1, 2, 3, 1, 1, 3, 2, 2, 5, 5, 1, 5, 5, 1, 4, 4, 3, 5, 4, 4 ";

            var numberOf1 = input.Count(x => x == '1');
            var numberOf2 = input.Count(x => x == '2');
            var numberOf3 = input.Count(x => x == '3');
            var numberOf4 = input.Count(x => x == '4');
            var numberOf5 = input.Count(x => x == '5');


            long[] timersOfFishes = new long[9] { 0, numberOf1, numberOf2, numberOf3, numberOf4, numberOf5, 0, 0, 0 };
                
            
            var s=timersOfFishes.Count();
            for (int days = 0; days <= 256; days++)
            {
                long[] newValue = new long[9];

                PrintArray(timersOfFishes);
                Console.WriteLine($"Dopo {days} giorni, ci sono: {SumFished(timersOfFishes)} pesci");
                newValue[0] = timersOfFishes[1];
                newValue[1] = timersOfFishes[2];
                newValue[2] = timersOfFishes[3];
                newValue[3] = timersOfFishes[4];
                newValue[4] = timersOfFishes[5];
                newValue[5] = timersOfFishes[6];
                newValue[6] = timersOfFishes[7] + timersOfFishes[0];
                newValue[7] = timersOfFishes[8];
                newValue[8] = timersOfFishes[0];

                timersOfFishes = newValue;                
            }
        }
        public static long SumFished(long[] arr)
        {
            return arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8];
        }

        public static void PrintArray(long[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item+",");
            }
        }

    }
}
