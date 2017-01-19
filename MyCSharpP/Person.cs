using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP
{
    class Person
    {
        //C# 和 Visual Basic 都允许你创建私有字段来存储属性值，或者使用常说的“自动实现的属性”，这些属性自动在后台创建此字段，并为属性过程提供基本逻辑。
        public string height { get; set; }

        public int _age;

        //public int age {
        //    // Return the value stored in a field.  
        //    get { return _age; }
        //    // Store the value in the field.  
        //    set { _age = value; }
        //}
    }
}
