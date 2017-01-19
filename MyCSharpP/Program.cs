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
            //调用无参的构造方法
            Student student1 = new Student();
            Console.WriteLine(student1.name);
            student1.SetName("anna");
            Console.WriteLine(student1.name);
            //调用有参的构造方法
            Student student2= new Student("jimu");
            Console.WriteLine(student2.name);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
