using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP
{
    class Student
    {
        public string name;

        public Student()
        {

        }

        public Student(string nm)
        {
            this.name = nm;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }
}
