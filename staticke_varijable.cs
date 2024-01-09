using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vjezba4
{
    class PrvaKlasa
    {
        private static int counter = 0;
        private string naziv;
        public PrvaKlasa(string naziv)
        {
            counter++;
            this.naziv = naziv;
        }
        
           
            public static int GetCounter() { return counter; }
        public string GetNaziv() { return naziv;  }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("prvi");
            Console.WriteLine(x.GetNaziv());
            Console.WriteLine("Vrijednost:" + PrvaKlasa.GetCounter());

            PrvaKlasa y= new PrvaKlasa("drugi");
            Console.WriteLine(y.GetNaziv());
            Console.WriteLine("Vrijednost:" + PrvaKlasa.GetCounter());

            PrvaKlasa z = new PrvaKlasa("treci");
            Console.WriteLine(z.GetNaziv());
            Console.WriteLine("Vrijednost:" + PrvaKlasa.GetCounter());
            Console.ReadKey();
        }
    }
}
