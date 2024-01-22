using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D5.SortedListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList SortedL = new SortedList();

            SortedL.Add(100, "Yüz");
            SortedL.Add(90, "Doksan");
            SortedL.Add(1, "Bir");
            SortedL.Add(9000, "Dokuzbin");
            // SortedL.Add("A", "B");
        }
    }
}
