using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam101
{
    internal class Program3
    {
        static void Main(string[] args)
        {


            //اكتب مقطع برنامج الذي يستقبل عدد صحيح موجب num
            //ثم يطبع خاناته بترتيب عكسي
            //int num=int.Parse(Console.ReadLine());

            //while (num > 0)
            //{
            //    int dig = num % 10;
            //    Console.Write(dig);
            //    num /= 10;
            //}
            //Console.WriteLine();
            //Console.WriteLine(num);


            //اكتب مقطع برنامج الذي يستقبل عدد صحيح موجب num
            //ثم يجد ويطبع العدد العكسي له
            int num = int.Parse(Console.ReadLine());
            int tmp = num;
            int mun = 0;

            while (tmp > 0)
            {
                int dig = tmp % 10;
                mun = mun * 10 + dig;
                tmp /= 10;
            }
            //Console.WriteLine(num);
            //Console.WriteLine(mun);

            Console.WriteLine("num:{0}, mun:{1}", num, mun);

            //int i = 1;
            //while (i <=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int j = 1; j <= 10; j++)
            //    Console.WriteLine(j);

            //while (true)
            //{
            //    Console.WriteLine("x?");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("y?");
            //    int y = int.Parse(Console.ReadLine());

            //    int mn = Math.Min(x, y);
            //    int result = 1;
            //    int i = 1;
            //    while (i <= mn)
            //    {
            //        if (x % i == 0 && y % i == 0)
            //            result = i;

            //        i++;
            //    }

            //    Console.WriteLine(result);
            //    Console.WriteLine();
            //}

        }
    }
}
