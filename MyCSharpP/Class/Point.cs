using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Class {
    class Point {
        //public readonly double p = 3.1415926;//和const类似，在运行期决定
        public string width;
        public string height;
        public string circle;
        public string this[string circle] {//索引重载
            set { this.circle = value; }
            get { return circle; }
        }
        public string this[int index] { //索引申明
            set {
                switch (index) {
                    case 0:
                        width = value;
                        break;
                    case 1:
                        height = value;
                        break;
                }
            }
            get {
                switch (index) {
                    case 0: return width;
                    case 1: return height;
                    default:
                        throw new ArgumentOutOfRangeException("index");
                        break;
                }

            }
        }
    }
}

