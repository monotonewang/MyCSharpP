using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Extends {
    class Extends {
        static void Main(String[] args) {
            //无论print是通过派生类调用还是通过基类调动，都是最派生类中的方法被调用，
            //当通过基类调用时，调用被沿着继承层次向上传递
            //VirtualDerived d=new VirtualDerived("ss",1);
            //VirtualClass basex = d;
            //d.print();
            //basex.print();
            //Console.ReadKey();
            //抽象测试
            AbstractClass a = new AbstractDerived();
            a.print("s");
            Console.ReadKey();

        }
    }
}
