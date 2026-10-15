namespace Adam101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.Write("Adam");
            //Console.Write("Adam");
            //int x; //تعريف متغير من نوع int
            //x = 5; //تعيين قيمة للمتغير
            //Console.WriteLine(x); //طباعة قيمة المتغير
            //Console.WriteLine("x");
            //كل نوع متغير تتعلمه في الصف يجب ان تعرف
            //تعريفه و تعيين قيمة له و طباعته
            //int y = 10; //تعريف متغير من نوع int و تعيين قيمة له
            //int a, b, c; //تعريف عدة متغيرات من نفس النوع

            //استقباله
            //a = int.Parse(Console.ReadLine()); //استقبال قيمة من المستخدم و تحويلها الى int
            //Console.WriteLine(a); //طباعة القيمة المستقبلة
            //طباعة مدمجة: نص وقيمة متغير
            //Console.WriteLine("The value of a is: " + a); //طباعة نص الزائد + وظيفته لصق
            //Console.WriteLine("The value of a is: {0} x:{1}", a, x);
            ////عمليات حسابية
            //الصحيح int : + - * / %
            //int m = 30 + 20; //جمع
            //Console.WriteLine(m);
            // m=30-20; //طرح  
            //Console.WriteLine(m);
            //m = 30 * 20; //طرح  
            //Console.WriteLine(m);
            //m = 30 / 20; //قسمة: قسمة عددين صحيحين دائما نتيجتها عدد صحيح
            //Console.WriteLine(m);
            //m = 30 % 20; //باقي القسمة  
            //Console.WriteLine(m);
            //Console.WriteLine();
            //Console.WriteLine(12*85);
            //Console.WriteLine(12/85);
            //Console.WriteLine(12 % 85);
            //Console.WriteLine(125/100);
            //Console.WriteLine(12548%10);
            //Console.WriteLine(12548 % 100);
            //Console.WriteLine(12548 / 100);
            //عمليات حسابية مختصرة

            int c = 0;
            c = c + 10;
            Console.WriteLine(c);
            int d;
            //d = d + 5; ممنوع استخدام متغير يدون اغطاؤه قيمة اولية مسبقا 
            //Console.WriteLine(d);
            //استخدام متغير: طباعته، تعبير حسابي، شرط

            //كتابات مختصرة
            c += 100; //c=c+100
            Console.WriteLine(c);
            c-= 50; //c=c-50
            Console.WriteLine(c);
            c *= 2; //c=c*2
            Console.WriteLine(c);
            c /= 4; //c=c/4
            Console.WriteLine(c);
            c %= 3; //c=c%3
            Console.WriteLine(c);

            int k = 9;
            k++; //d=d+1 d+=1
            k += 17; //k=k+17 k+=17
            k--; //k=k-1 k-=1
            Console.WriteLine(k);

            //عمليات حسابية متقدمة
        }
    }
}
