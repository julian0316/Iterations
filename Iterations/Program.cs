using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your years of experience");
            int a = int.Parse(Console.ReadLine());
            int i = 0;
                while (i <= a)
           
            {
                Console.WriteLine("You have {0} years experience",i);
                i++;
            }
        }

    }
}
