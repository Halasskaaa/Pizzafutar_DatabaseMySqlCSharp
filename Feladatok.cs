using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pizzafutar
{
    internal class Feladatok
    {
        List<Rendeles> lista;
        public Feladatok()
        {
            Adatbazis a = new Adatbazis();
            lista = a.Feltolt();
            //PizzaAr();
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
            var eredmeny = lista
                .Where(p => p.Pizza.Ar < 1500)
                .Select(pizza => new
                {
                    pizza.Pizza.Nev,
                    pizza.Pizza.Meret,
                    pizza.Pizza.Ar
                })
                .GroupBy(p => new {p.Nev, p.Meret, p.Ar})
                .Select(p => p.First())
                .OrderBy(p => p.Meret)
                .ThenBy(p => p.Nev);

            foreach (var p in eredmeny)
            {
                Console.WriteLine($"{p.Nev} - {p.Meret} - {p.Ar}Ft");
            }
        }

        private void Nepszeru4()
        {
//            SELECT
//    pizza.Nev, 
//    pizza.Meret, 
//    COUNT(*) AS Dbszam
//FROM rendeles
//JOIN pizza ON rendeles.PizzaID = pizza.ID
//GROUP BY pizza.Nev, pizza.Meret
//ORDER BY Dbszam DESC
//LIMIT 1;
        }
    }
}
