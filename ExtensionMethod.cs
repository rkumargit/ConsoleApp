﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
     static class ExtensionMethod
    {
        public static void ExtMethod(this string a)
        {
            Console.WriteLine("This is ext method from class A");
        }
    }

    partial   class A
    {
       partial void MethodA(string message);

        public void OutParamMethod(out int id, out string message, out bool choice)
        {
            id = 1;
            message = "from Out param method";
            choice = true;
        }
        public void RefParamMethod(ref int id, ref string message, ref bool choice)
        {
            message = "Changed in Ref method";
        }

        public static void StaticMethod()
        {
            Console.WriteLine("From static method");
        }
    }

  
   
}
