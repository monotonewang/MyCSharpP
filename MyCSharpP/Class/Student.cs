using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP
{
    //继承是通过使用“派生”来实现的，而派生意味着类是使用“基类”声明的，它的数据和行为从基类继承。 通过在派生的类名后面追加冒号和基类名称，可以指定基类
    class Student : Person
    {
        public const int value = 10;//成员常量必须初始化
         
        public int width;//实例字段

        public static int height;//静态字段

        public string Name { get; set; }

        public int Age { get; set; }

        public Student()
        {

        }
        //这是构造方法
        public Student(string nm,int age)
        {
            this.Name = nm;
            this.Age = age;
        }
        
        public void SetName(string newName)
        {
            Name = newName;
        }
        /*
         * p1 和 p2 的内存在线程堆栈上进行分配。 该内存随声明它的类型或方法一起回收。 
         * 这就是在赋值时复制结构的一个原因。 相比之下，当对类实例对象的所有引用都超出范围时，
         * 为该类实例分配的内存将由公共语言运行时自动回收（垃圾回收）。 无法像在 C++ 中那样明确地销毁类对象
         */
        public void visitBymethod() {
            //关于类里面的属性问题。
            //调用有参的构造方法
            Student student1 = new Student("jimu", 6);
            Console.WriteLine("Press any key to exit.");
            Console.WriteLine("student1 name={0}age={1}", student1.Name, student1.Age);
            Student stu2 = student1;
            stu2.Name = "molly";
            stu2.Age = 19;
            Console.WriteLine("stu2 name={0}age={1}", stu2.Name, stu2.Age);
            Console.WriteLine("student1 name={0}age={1}", student1.Name, student1.Age);
            Console.ReadKey();
        }

        /*
         通过属性来访问
             */
        public void visitByattribute() {
            // Create  struct instance and initialize by using "new".
            // Memory is allocated on thread stack.
            Student p1 = new Student("Alex", 9);
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

            // Create  new struct object. Note that  struct can be initialized
            // without using "new".
            Student p2 = p1;

            // Assign values to p2 members.
            p2.Name = "Spencer";
            p2.Age = 7;
            Console.WriteLine("p2 Name = {0} Age = {1}", p2.Name, p2.Age);

            // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
