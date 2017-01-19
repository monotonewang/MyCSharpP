using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP
{
    class Program{
        static void Main(string[] args)
        {
            //system.console.writeline("test vs2015!");
            //// keep the console window open in debug mode.
            Console.WriteLine("press any key to exit.");
            //Console.ReadKey();

            Student s1 = new Student();
            s1.visitBymethod();
            s1.visitByattribute();



            //test
        }
    }
}
