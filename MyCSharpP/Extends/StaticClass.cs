using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Extends {
    static public class StaticClass {
        public static float PI = 3.14f;
        public static bool idOdd(int x) {
            return x % 2 == 1;
        }
        public static int timeAdd(int x) {
            return 2 * x;
        }
        //外部方法
        [DllImport("kernel32,SerLastError=true")]
        public static extern int getCurrentDirectory(int size, StringBuilder buf);

    }
}
