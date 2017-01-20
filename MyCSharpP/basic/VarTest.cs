using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.oriented
{
    class VarTest
    {
        static void Main(string[] args) {
            //C# 3.0 开始支持 显式的类型名
            var total = 15;
            {
                var  var1 = 18;
            }
            var person = new Person();

            Console.WriteLine("total={0}",total);
            Console.WriteLine("person=", person);
            Console.ReadKey();
        }
    }
}
