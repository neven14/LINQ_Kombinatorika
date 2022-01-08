using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Kombinatorika
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
            return true;
            void Main(string[] args)
            {
                int broj = 100000000;
                int[] brojArray;
                int[] brojArrayTemp = { };
                int b = 8;
                while (true)
                {
                    brojArray = Array.ConvertAll(broj.ToString().ToArray(), x => (int)x - 48);
                    if (brojArray.Length == brojArray.Distinct().Count() && brojArray.Contains(0) != true)
                        if (IsPrime(brojArray[b]) == true)
                        {
                        }
                    brojArrayTemp[b] = 9;
                    b = b - 1;
                    break;
                    broj++;
                }
                foreach (int e in brojArrayTemp)
                {
                    Console.WriteLine(e);
                }
                Console.ReadKey();
            }
        }
    }
}
