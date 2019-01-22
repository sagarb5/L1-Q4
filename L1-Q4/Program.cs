using System;

namespace L1_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the value of n :");
            int n, sum=0;
            n = int.Parse(Console.ReadLine());
            for ( int i=1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of the first n numbers is = {0}", +sum);
            Console.ReadLine();
        }
    }
}
