using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class FunctionOverloading
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.Add(10, 30));
            Console.WriteLine(myMath.Add("Function ", "Overloading"));
            Console.ReadLine();
        }
    }
}
