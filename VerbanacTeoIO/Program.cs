using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace VerbanacTeoIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"C:\Users\Ucenik\Documents";
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }
            string mapa = putanja + "//test";
            if(Directory.Exists (mapa))
            {
                Console.WriteLine("\nMapa izbrisana");
                Directory.Delete(mapa);
            }
            else
            {
                Directory.CreateDirectory(mapa);
            }
            //ispis podmapi

            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Podmape: ");
                foreach (string datoteka in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }
              Console.ReadKey();
        }
    }
}
