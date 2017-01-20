using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Class
{
    class Teacher
    {
        static int age;
        int _age;
        public static int myAge
        {
            set { age = value; }
            get { return age; }
        }
           
        //没有参数的构造方法
        public Teacher()
        {

        }
        //带参数的构造方法
        public Teacher(int age)
        {
            this._age = age;
        }
       
        private string name
        {
            set;
            get;
        }

        //自定义set方法
        public void setName(String name)
        {
            this.name = name;
        }
        //自定义get方法
        public string getName()
        {
            return name;
        }
        //通过类内部调用属性
        public void printValue()
        {
            Console.WriteLine("value={0}", myAge);
        }
    }
}
