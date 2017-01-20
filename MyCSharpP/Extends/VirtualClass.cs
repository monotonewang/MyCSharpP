using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Extends {
    //定义了internal 不同dll不能相互调用
    //public   公有的
    //private  私有的
    //protected 受保护的
    //internal  内部的
    //protected internal 受保护内部的

    //virtual 1.能被重写，2.方法有方法体
    internal class VirtualClass {

        public VirtualClass(string msg, int i) {

        }

        virtual public void print() {
            Console.WriteLine("virtual method");
        }
    }
}
