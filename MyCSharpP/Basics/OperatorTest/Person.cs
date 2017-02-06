using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Basics.OperatorTest {
    class Person {
        public string name;
        public int age;
        public static Person operator +(Person a, Person b) {
            Person p = new Person();
            p.name = a.name + b.name;
            p.age = a.age + b.age;
            return p;
        }
    }
}
