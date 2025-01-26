using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入课程门数n");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            double a, b, c, d, e;
            c = 0;
            d = 0;
            e = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("这是第{0}门科目",i+1);
                Console.WriteLine("请输入课程学分");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入课程成绩");
                b = Convert.ToDouble(Console.ReadLine());
                c = a * b;
                e= e+ c;
                d = d + a;
            }
            Console.WriteLine("你的平均分为：{0}", e/ d);

        }
    }
}
