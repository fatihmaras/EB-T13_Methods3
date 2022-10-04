using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar_Ornek_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());

            KontrolEt(sayi1, sayi2);
            Console.ReadLine();


        }
        static void KontrolEt(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("1.Sayı 2.Sayıdan Büyüktür...");
            }
            else if (a == b)
            {
                Console.WriteLine("İki Sayının Değeri Eşittir");
            }
            else
            {
                Console.WriteLine("1.Sayı 2.Sayıdan Küçüktür");
            }
        }
    }
}
