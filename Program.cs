using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    class Cat
    {
        bool opasna;

        public bool Opasna { get => opasna; set => opasna = value; }

        public virtual void Opasnost()
        {
            this.opasna = false;
        }
        public override string ToString()
        {
            return "Macka - Opasnost = " + this.Opasna;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            this.Opasna = true;
        }

        public override string ToString()
        {
            return "Gepard - Opasnost = " + this.Opasna;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard gepard = new Gepard();
            gepard.Opasnost();
            Console.WriteLine(gepard.ToString());

            Cat macka = new Cat();
            macka.Opasnost();
            Console.WriteLine(macka.ToString());

            Console.ReadKey();
        }

    }

}