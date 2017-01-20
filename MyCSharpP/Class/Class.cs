using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Class
{
    class Class
    {
        static void Main(string[] args)
        {
            
            Student s1 = new Student();
            s1.width = 20;//实例字段的访问方式
            Student.height = 10;//静态字段的访问方式
            int i= Student.value;//成员常量的访问方式
            //s1.visitBymethod();
            //s1.visitByattribute();

            //第一种访问属性的方法
            Teacher t1 = new Teacher();
            //t1.name = "lisi";
            //Console.WriteLine("1.t1.name={0}", t1.name);
            //第二种通过其他方法访问属性
            //t1.setName("wangwu");
            //Console.WriteLine("2.t1.name={0}", t1.getName());
         

            //静态属性
            Console.WriteLine("age={0}", Teacher.myAge);

            Teacher.myAge = 10;
            Console.WriteLine("age={0}", Teacher.myAge);
        
            t1.printValue();
            Console.ReadKey();


        }
    }
}
