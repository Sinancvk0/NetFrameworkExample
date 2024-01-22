﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static : nesne örneği alınmadan ulaşabildiğimiz metot , field , sınıf.. 
            // Tip M1 = new Tip();
            // Tip.

            // Stack bölge içerisinde pointer ımız oluştu... 
            Ogrenci O1;
            // Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field , metot static dediğimiz bölgede oluşturuldu.
            Ogrenci.Test2();

            O1 = new Ogrenci();
            // Stack bölgede pointer => kendisini heap bölgede tamamladı.. static olmayan tanımlarını tamamladı.. 
            O1.Test1(); // nesne örneği alındıktan sonra test1 adındaki metotuma ulaşabidim. 

            /* Static Kavramı gerçek hayatta nerelerde kullanılır... 

            1 - Helper.cs => Kontroller
            2 - Olusturmuş olduğumuz nesnemizin => bağımlılığı farklı class lara olduğu için ( proje içerisinde özel olduğu icin ) nesne içerisinde static metot tanımları yapılır. 
            3 - Class içerisinde bir field ( static ) tanımı yapar ilgili field içerisine bir değer ataması yaparız. Daha sonra uygulama içerisinde N farklı yerde oluşturmuş olduğumuz static field ımıza ulaşır değerimizi okuruz. 
            4 - [ Uygulama ] => [ozelHelper] => [ DLL ]

            */


        }
    }
}
