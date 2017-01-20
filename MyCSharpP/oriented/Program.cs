using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP
{
    class Program{
        //static void Main(string[] args)
        //{
            //system.console.writeline("test vs2015!");
            //// keep the console window open in debug mode.
            //Console.WriteLine("press any key to exit.");
            //Console.ReadKey();

            //Student s1 = new Student();
            //s1.visitBymethod();
            //s1.visitByattribute();

            int i = 10,j=20;
            ////取地址符
            //changeNum(ref i,ref j);
            //Console.WriteLine("i={0},j={1}", i, j);
            //Console.ReadKey();            //test

            //int max = getMaxValue(i,j);
            //Console.WriteLine("max={0}", max);
            //Console.ReadKey();
            //getStringLength();

            //int sum=getSum(100);
            //Console.WriteLine("sum={0}", sum);
            //Console.ReadKey();

        //}
        static void changeNum(ref int i,ref int j)
        {
            int temp = j;
            j = i;
            i = temp;  
        }

        static int getMaxValue(int i,int j) {
            return i > j ? i : j;
        }

        static void getStringLength()
        {
            Console.WriteLine("请输入一个字符串，计算字符串的长度");
            string msg = Console.ReadLine();
            Console.WriteLine("字符串长度={0}" + msg.Length);
            Console.ReadKey();
        }

        static int getSum(int i) {
            int sum = 0;
            for (int j = 0; j < i; j++) {
               sum= sum + j;
            }
            return sum;
        }


    }
}
