﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class NOKIA1100: NOKIA1400
    {
        public NOKIA1100()
        {
            Console.WriteLine("Default Constructor of NOKIA1100");
        }

        public string MP4()
        {
            return "MP4() calling from NOKIA1100";
        }
    }
}
