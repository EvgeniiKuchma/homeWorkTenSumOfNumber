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
            Random rand = new Random();
            int number = rand.Next(0, 100);
            int sumNumber = 0;
            int multiple1 = 3;
            int multiple2 = 5;

            while (number > 0)
            {
                
                if (number % 3 == 0 || number % 5 == 0)
                {
                    sumNumber += number;
                }
                number--;
            } 
            Console.WriteLine(sumNumber);
            }
        }
    }
