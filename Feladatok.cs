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
            Kiir();
        }
        private void Kiir()
        {
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Cim.Nev} - {item.Pizza.Nev} - {item.Darab}");
            }
        }
    }
}
