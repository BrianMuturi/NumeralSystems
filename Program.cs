using System;

namespace NumeralSystems
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }

        static void Decimal()
        {
            Console.Write("Enter number to convert:");
            int number = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(number, 2);

            Console.Write("In Binary:" + { binary});
        }

        /*static void Octal()
        {
            Console.Write("Enter number to convert:");
            int number = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(binary);
        }*/

    }
}
