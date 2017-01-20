using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP
{
    class Class
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Student s1 = new Student();
            s1.width = 20;//实例字段的访问方式
            Student.height = 10;//静态字段的访问方式
            int i= Student.value;//成员常量的访问方式
            s1.visitBymethod();
            s1.visitByattribute();
        }
    }
}
