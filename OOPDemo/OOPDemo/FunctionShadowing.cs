using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class FunctionShadowing
    {
        static void Main()
        {
            MyMath1 myMath1 = new MyMath1();
            Console.WriteLine(myMath1.Add(30.3, 20.6));
            Console.ReadLine();
        }
    }
}
