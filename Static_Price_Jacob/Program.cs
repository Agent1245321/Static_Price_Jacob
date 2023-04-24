using System;

namespace Static_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the float overload
            Console.WriteLine(Calculate.Add(1.3f, 4.5f));
            Console.WriteLine(Calculate.Subtract(1.3f, 4.5f));
            Console.WriteLine(Calculate.Multiply(1.3f, 4.5f));
            Console.WriteLine(Calculate.Divide(1.3f, 4.5f));

            //using the int overload
            Console.WriteLine(Calculate.Add(1f, 4f));
            Console.WriteLine(Calculate.Subtract(1f, 4f));
            Console.WriteLine(Calculate.Multiply(1f, 4f));
            Console.WriteLine(Calculate.Divide(1f, 4f));
        }
    }
}
