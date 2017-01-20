using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Class {
    //分布类
    partial class Partial {
        public void method1() {
            Console.WriteLine("method1");
        }
    }
    partial class Partial {
        public void method2() {
            Console.WriteLine("method2");
            Console.ReadKey();
        }
    }
}
