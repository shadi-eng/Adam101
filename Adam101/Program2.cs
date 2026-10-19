using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam101
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //عمليات حسابية متقدمة
            double x = Math.Pow(10, 7);
            double r = Math.Sqrt(10);
            int p = Math.Abs(-10);
            int m = Math.Max(100, 20);
            int mn = Math.Min(9, 45);
            //msa7t daera nsf qtrha 10
            double ms = 10 * 10 * Math.PI;
            double rr = Math.Round(ms,2);

            ///اكتب مقطع برنامج الذي يستقبل عدد صحيح ويفحص اذا كان ثلاثي الخانات
            //Console.WriteLine("enter int value");
            //int a=int.Parse(Console.ReadLine());
            //if(a>=100 && a<=999)
            //{
            //    Console.WriteLine("the value {0} is three digits",a);
            //}
            //else
            //{
            //    Console.WriteLine("the value {0} is not three digits",a);
            //}


            ///اكتب مقطع كود الذي يختار ويطبع عدد عشوائي بين 1-10
            Random rn = new Random();
            int i = 0;
            while(i<10)
            {
                int x1 = rn.Next(1, 1001);
                Thread.Sleep(500);
                //Console.WriteLine("Random Value:" + x1);
                if(x1>500)
                    Console.WriteLine("{0} is wow",x1);
                else
                    Console.WriteLine("{0} is NOO", x1);
                i++;
            }


            //for(int i=0;i<10;i++)
            //{
            //    int x1 = rn.Next(1, 101);
            //    Thread.Sleep(100);
            //    Console.WriteLine("Random Value:" + x1);
            //}
            //int x2=rn.Next(1, 101);
            //Console.WriteLine("Random Value:" + x2);
            // Console.WriteLine("Random Value:{0}", x2);


        }
    }
}
