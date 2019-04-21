using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("kaç tane sayı gireceksiniz?");
            n = Convert.ToInt32(Console.ReadLine());
            //int x = 1;
            int btoplam = 0;
            int ctoplam = 0;
            int ktoplam = 0;
            int b = 0;
            int c = 0;
            int k = 0;
          
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine("sayıyı giriniz:");
                int s;
                s = Convert.ToInt32(Console.ReadLine());
                if (s % 5 == 0)
                {
                   // Console.WriteLine(" 5 e bölünebilir");
                        b = b + 1;
                    btoplam = btoplam + s;
                }
                if (s%3==0)
                {
                    //Console.WriteLine("3 e bölünebilir");
                    c = c + 1;
                    ctoplam = ctoplam + s;
                }
                if (s%2==0)
                {
                   // Console.WriteLine("2 ye bölünebilir");
                    k = k + 1;
                    ktoplam = ktoplam + s;
                }
              

            }
           
                Console.WriteLine("girilen 10 tane sayıdan 5 e bölünebilen sayı adedi " + b);              
                Console.WriteLine("girilen 10 tane sayıdan 3 e bölünebilenlerin adedi " + c);
                Console.WriteLine("girilen 10 tane sayıdan 2 ye bölünebilenlerin adedi " + k);
                Console.WriteLine("girilen 10 tane sayıdan 5 e bölünebilenlerin toplamı " + btoplam);
                Console.WriteLine("girilen 10 tane sayıdan 3 e bölünebilenlerin toplamı " + ctoplam);
                Console.WriteLine("girilen 10 tane sayıdan 2 ye bölünebilenlerin toplamı " + ktoplam);
                Console.ReadLine();



        }
    }
}
