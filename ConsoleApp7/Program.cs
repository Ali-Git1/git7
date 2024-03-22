using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method(10);



            //Fibonacci

            int a = 1;
            int b = 1;
            int sum = 0;

            for (int i = 1; i < 10; i++)
            {

               
                int c = a + b;
                Console.WriteLine($"{i}. Fibonacci eded: {c}, Reqemlerin cemi: {Sum(c)}");
                sum += Sum(c);
               



                bool check = false;

                for (int j = 2; j * j <= Sum(c); j++)
                {
                    if (Sum(c) % j == 0)
                    {
                        check = true;
                        break;
                    }
                }

                if (check || Sum(c) <= 1)
                {
                    Console.WriteLine($"{Sum(c)} Murekkeb ededdir");
                }
                else
                {
                    Console.WriteLine($"{Sum(c)} Sade ededdir");
                }

                a = b;
                b = c;

            }


            

        }


        static void Method(int n)
        {
            //Verilmis int ededini tersden yazan program

            //Console.WriteLine("Ededinizi daxil edin");
            //n = Convert.ToInt32(Console.ReadLine());

            //int reqem =0;

            //Console.WriteLine("Cevrilmis eded");
            //while (n > 0)
            //{
            //        reqem = reqem * 10;
            //        reqem = reqem + n % 10;
            //        n = n / 10;
                
            //}
            //Console.WriteLine(reqem);


        }


        static int Fibonocci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;




            if (n <= 1)
                return n;

            for (int i = 1; i <= 10; i++)
            {

                c = a + b;
                a = b;
                b = c;



            }
            return c;
        }

        static int Sum(int say)
        {
            int sum = 0;

            while (say != 0)
            {
                sum += say % 10;
                say /= 10;
            }
            return sum;
        }
    }
}
