using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Basics {
    class LimitedInt {
        const int maxValue = 100;
        const int minValue = 0;
        private int _TheValue = 0;
        public int TheValue {
            get { return _TheValue; }
            set {
                if (value < minValue)
                    _TheValue = 0;
                else
                    _TheValue = value > maxValue ? maxValue : value;
            }
        }
        public static LimitedInt operator -(LimitedInt x) {
            LimitedInt li = new LimitedInt();
            li.TheValue = 0;
            return li;
        }

        public static LimitedInt operator -(LimitedInt x, LimitedInt y) {
            LimitedInt li = new LimitedInt();
            li.TheValue = x.TheValue - y.TheValue;
            return li;
        }

        public static LimitedInt operator +(LimitedInt x, double y){
            LimitedInt li = new LimitedInt();
            li.TheValue = x.TheValue+(int)y;
            return li; 
        }
    }
}
