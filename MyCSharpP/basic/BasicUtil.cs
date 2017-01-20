using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpP.Basic
{
    class BasicUtil
    {
        //方法重载
        public static int addInt(int a,int b)
        {
            return 1;
        }

        public static int addInt(int a)
        {
            return 1;
        }

        public static int addInt()
        {
            return 1;
        }

        //递归调用
        public  static int DiGui(int i) {
       
            if (i <= 1)
            {
                Console.WriteLine("i={0}", i);
                //Console.ReadLine();
                return i;
            }
            else {
                int value = 0;
                value = i * DiGui(i - 1);
                Console.WriteLine("i={0}", value);
              
                return value;
            }
        }
       
        //foreach 遍历
        public static void arrayForeach(params int[] values) {
            foreach (int i in values) {
                Console.WriteLine("values[{0}]", i );
            }
            Console.ReadKey();
        }
        //声明一个参数类型的数组，1.需要在数据类型前有params 关键字(没有params是不支持直接在传入参数的时候直接使用可变参数)。
        //2.数据类型后需要有[]。
        public static void arrayAdd(params int[] values)
        {
            if ((values != null) && (values.Length != 0))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = values[i] + 10;
                    Console.WriteLine("values[{0}]={1}", i, values[i]);
                }
                Console.ReadKey();
            }
        }
        //C# 3.0 开始支持 显式的类型名
        static void VarTest()
        {
            var total = 15;
            {
                var var1 = 18;
            }
            var person = new Person();
            DateTime dt = DateTime.Now;
            Console.WriteLine("total={0},nowtime={1}", total, dt);
            Console.WriteLine("person=", person);
            Console.ReadKey();
        }
        //将字符串"  hello      world,你  好 世界   !    "两端空格去掉，并且将其中的所有其他空格都替换成一个空格，输出结果为："hello world,你 好 世界 !"。
        public static void msgTrim()
        {
            string msg = "  hello      world,你  好 世界   !    ";
            //1.去掉两端空格
            //msg.Trim();
            //Console.WriteLine(msg);//不对！字符串具有不可变性
            msg = msg.Trim();

            //把整个字符串msg,按照单个“空格”分割开
            //string[] parts = msg.Split(' ');
            string[] parts = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //把parts数组中的每个元素以 “空格” 作为连接符，连接起来
            msg = string.Join(" ", parts);
            Console.WriteLine("======" + msg + "=========");
            Console.ReadKey();
        }

        //交换两个数的位置
        static void changeNum(ref int i, ref int j)
        {
            int temp = j;
            j = i;
            i = temp;

        }
        //获取最大数
        static void getMaxValue(int i, int j)
        {
            int max = 0;
            max = i > j ? i : j;
            Console.WriteLine("max={0}", max);
            Console.ReadKey();
            return;
        }
        //获取string的长度
        static void getStringLength()
        {
            Console.WriteLine("请输入一个字符串，计算字符串的长度");
            string msg = Console.ReadLine();
            Console.WriteLine("字符串长度={0}" + msg.Length);
            Console.ReadKey();
        }
        //获取0到i的和
        static void getSum(int i)
        {
            int sum = 0;
            for (int j = 0; j < i; j++)
            {
                sum = sum + j;
            }
            Console.WriteLine("sum={0}", sum);
            Console.ReadKey();
            return;
        }
    }
}
