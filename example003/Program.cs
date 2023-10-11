using System;

namespace example003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " + " + n2 + " = " + n1+n2);
        }
    }
}
