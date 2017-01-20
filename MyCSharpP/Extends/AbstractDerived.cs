using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Extends {
    class AbstractDerived : AbstractClass {
        public override int myProperty {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public override void print(string s) {
            Console.WriteLine("AbstractDerived-print");
            throw new NotImplementedException();
        }
    }
}
