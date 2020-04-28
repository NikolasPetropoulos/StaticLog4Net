using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace StaticLog4Net
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            
            string ex = "Main method exception";
            Log4Net.L4Method(ex);
            Test tst = new Test();
            tst.testMethod();
            Console.ReadLine();

        }
    }
}
