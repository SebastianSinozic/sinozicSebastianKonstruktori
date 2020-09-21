using System;

namespace sinozicSebastianKonstruktori
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Upišite x vrijednost: ");
            x.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite z vrijednost: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite y vrijednost: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());

            if (x.Postotak + z.Postotak + y.Postotak != 100)
            {
                Console.WriteLine("Neispravan unos podataka!");
            }
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najviše se koristi Proceduralni!");
                }
                else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najviše se koristi Objektni!");
                }
                else if (z.Postotak > x.Postotak && z.Postotak > y.Postotak)
                {
                    Console.WriteLine("Najviše se koristit Funkcionalni!");
                }
            }


            Console.ReadKey();
        }
    }
}
