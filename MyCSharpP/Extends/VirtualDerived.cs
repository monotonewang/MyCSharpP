using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Extends {
    class VirtualDerived :VirtualClass{

        //调用父类的构造方法
        public VirtualDerived(String msg,int i):base (msg,i) {

        }
        //滴啊用不同类型的构造方法
        public VirtualDerived(int x) : this("xx", x) {

        }
        //无论print是通过派生类调用还是通过基类调动，都是最派生类中的方法被调用，
        //当通过基类调用时，调用被沿着继承层次向上传递
        //override public void print() {
        //    Console.WriteLine("override method");

        //}

        //只会向上传递一层，先调用本类方法，再调用上一级print方法
        //new public void print() {
        //    Console.WriteLine("override method");
        //}
    }
}
