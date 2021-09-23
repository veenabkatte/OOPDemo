using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class NOKIA1400: MobilePhone
    {
        public NOKIA1400()
        {
            Console.WriteLine("Default constructor of NOKIA1400");
        }

        public string MP3()
        {
            return "MP3() calling from NOKIA1400";
        }
    }
}
