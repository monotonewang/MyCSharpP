using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Extends {
    abstract class AbstractClass {

        //抽象方法
        abstract public void print(String s);
        //抽象属性
        abstract public int myProperty {
            set; get;
        }

    }
}

