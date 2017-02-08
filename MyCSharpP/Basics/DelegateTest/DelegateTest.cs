using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Basics.DelegateTest {
    class DelegateTest {
        public delegate void MyDelegate(string name);

        public static void MyDelegateFunc(string name) {
            Console.WriteLine("hello",name);
            Console.ReadKey();
        }
        public static void Main() {
            MyDelegate md = new MyDelegate(DelegateTest.MyDelegateFunc);
            md("san");
        }
    }
}
