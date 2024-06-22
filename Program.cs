using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkTenSumOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxRange = 100;
            Random random = new Random();
            int number = random.Next(0, maxRange);
            int sumNumber = 0;
            int multiple1 = 3;
            int multiple2 = 5;

            for (int i = 0; i <= number; i++)
            {
                if (number % multiple1 == 0 || number % multiple2 == 0)
                {
                    sumNumber += number;
                }

                number--;
            }

            Console.WriteLine(sumNumber);
        }
    }
}
