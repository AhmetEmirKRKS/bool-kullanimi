using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_.alıştırmalar5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Merhaba");
            Console.WriteLine("öğrencinin 1.notu:");
            string not1 = Console.ReadLine();
           int inot1=Convert.ToInt32(not1);
            Console.WriteLine("öğrencinin 2.notu:");
            string not2 = Console.ReadLine();
            int inot2 = Convert.ToInt32(not2);
            Console.WriteLine("öğrencinin 3.notu:");
            string not3 = Console.ReadLine();
            int inot3 = Convert.ToInt32(not3);
            int ortalama = (inot1 + inot2 + inot3) / 3;
                
            Console.WriteLine("ortalama:");
            Console.WriteLine(ortalama);
           bool kontrol = ortalama >= 45;
            Console.WriteLine(kontrol);
            Console.ReadLine();
            Console.Clear();
           
        }
    }
}
