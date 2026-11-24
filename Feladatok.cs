using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzafutar
{
    internal class Feladatok
    {
        List<Rendeles> lista;
        public Feladatok()
        {
            Adatbazis a = new Adatbazis();
            lista = a.Feltolt();
            PizzaAr();
            Olcso3();

        }
        private void PizzaAr()
        {
            Console.WriteLine("Pizzák ára:");
            foreach (var item in lista)
            {
                //Console.WriteLine($"{item.Cim.Nev} - {item.Pizza.Nev} - {item.Darab}");
                Console.WriteLine($"{item.Pizza.Nev} - {item.Pizza.Meret} - {item.Pizza.Ar} Ft");
            }
        }

        private void Olcso3()
        {
            Console.WriteLine("1500Ft-nál olcsóbb pizzák:");
        }
    }
}
