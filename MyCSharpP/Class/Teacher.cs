using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Class {
    class Teacher {
        static int age;
        int _age;

        //静态构造函数
        static Teacher() {
            age = new Random().Next();
            Console.WriteLine("静态的随机数-age={0}", age);
        }

        public static int myAge {
            set { age = value; }
            get { return age; }
        }


        //没有参数的构造方法
        public Teacher() {
            Console.WriteLine("无参构造方法");
        }
        //带参数的构造方法
        public Teacher(int age) {
            Console.WriteLine("有参构造方法");
            this._age = age;
        }
        public Teacher(String age) {
            Console.WriteLine("有参构造方法 -string");

        }

        private string name {
            set;
            get;
        }

        //自定义set方法
        public void setName(String name) {
            this.name = name;
        }
        //自定义get方法
        public string getName() {
            return name;
        }
        //通过类内部调用属性
        public void printValue() {
            Console.WriteLine("value={0}", myAge);
        }
    }
}
