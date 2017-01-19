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
        public string name { get; set; }

        public int age { get; set; }

        public Student()
        {

        }
        //这是构造方法
        public Student(string nm,int age)
        {
            this.name = nm;
            this.age = age;
        }
        
        public void SetName(string newName)
        {
            name = newName;
        }
    }
}
