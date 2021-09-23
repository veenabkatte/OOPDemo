using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class FunctionOverriding
    {
        static void Main()
        {
            MyMath1 myMath = new MyMath1();
            Console.WriteLine(myMath.Increment(10));

            Employee employee = new Employee(100, "Scott", "scott@gmail.com");
            Console.WriteLine(employee.ToString());

            Employee employee1 = new Employee(100, "Scott", "scott@gmail.com");
            Console.WriteLine(employee1.Equals(employee) ? "Both are same" : "Both are not same");
            Console.ReadLine();
        }
    }
}
