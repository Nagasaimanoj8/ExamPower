using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter Range of finding power table");
            string n= Console.ReadLine();
            int num=int.Parse(n);
            if (0<=num && num<31)
            {       
           
                Console.WriteLine();
                Console.WriteLine("Printing all till Power Value"+num);
                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine("Power of 2^" +i+ "is:" +(Math.Pow(2,i)));
                }
                
                Console.ReadLine();
            }
            
            else
            {
                Console.WriteLine("Please enter number between 0 to 31");
                Console.ReadLine();
            }
        }
    }
}
