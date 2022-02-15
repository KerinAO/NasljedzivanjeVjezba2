using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljeđivanjeVjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Unesite vrijednost postotka za Proceduralni programski jezik: ");
            x.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite vrijednost postotka za Objektni programski jezik: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite vrijednost postotka za Funkcionalni programski jezik: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());

            if (x.Postotak + y.Postotak + z.Postotak != 100)
            {
                Console.WriteLine("Neispravan unos podataka! ");
            }
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzastupljeniji je Proceduralni programski jezik");
                }
                if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzastupljeniji je Objektni programski jezik");
                }
                if (z.Postotak > y.Postotak && z.Postotak > x.Postotak)
                {
                    Console.WriteLine("Najzastupljeniji je Funkcionalni programski jezik");
                }
            }

            Console.ReadKey();
        }
    }

    class ProgramskiJezik
    {
        double postotak;

        public double Postotak { get => postotak; set => postotak = value; }

    }

    class Proceduralni : ProgramskiJezik
    {

    }

    class Objektni : ProgramskiJezik
    {

    }

    class Funkcionalni : ProgramskiJezik
    {

    }
}
