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

            //关于类里面的属性问题。
            //调用有参的构造方法
            Student student1 = new Student("jimu",6);
            Console.WriteLine("student1 name={0}age={1}", student1.name, student1.age);
            Console.WriteLine("Press any key to exit.");
            Student stu2 = student1;
            stu2.name = "molly";
            stu2.age = 19;
            Console.WriteLine("stu2 name={0}age={1}", stu2.name, stu2.age);
            Console.WriteLine("student1 name={0}age={1}", student1.name, student1.age);
            Console.ReadKey();

            //test
        }
    }
}
