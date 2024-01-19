using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace età_2
{
    internal class Program
    {
        static void Main(string[] args)
        { Persona p = new Persona();
            Console.WriteLine("inserire la data di nascita");
            p.datadinascita=DateTime.Parse(Console.ReadLine());

            Console.WriteLine("l'età è: {0}", p.Età()); 

            Console.ReadLine();
        }
    }
}
