using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D8.SwitchCaseKullanim2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciGelenDeger = string.Empty;

            // Goto kullanımı için bir başlık tanımlaması yapalım. 

            YenidenSecim:

            Console.WriteLine("Lütfen bulunduğunuz ay'ın sayısal değerini yazınız ve projenin hangi fazda olduğunu öğreniniz.");
            kullaniciGelenDeger = Console.ReadLine();

            switch (kullaniciGelenDeger)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("1.Faz");
                break;

                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("2.Faz");
                    break;
                case "9":
                case "10":
                case "11":
                case "12":
                    Console.WriteLine("3.Faz");
                    break;

                default:
                    Console.WriteLine("Aralık dışı değer girişi yaptınız...");
                    goto YenidenSecim;
            }
        }
    }
}
