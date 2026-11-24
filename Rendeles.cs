using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzafutar
{
    internal class Rendeles
    {
        private int id;
        private Pizza pizza;
        private int darab;
        private Cim cim;
        private TimeSpan ido;

        public Rendeles(int id, Pizza pizza, int darab, Cim cim, TimeSpan ido)
        {
            this.id = id;
            this.pizza = pizza;
            this.darab = darab;
            this.cim = cim;
            this.ido = ido;
        }

        public int Id { get => id; }
        public int Darab { get => darab; set => darab = value; }
        public TimeSpan Ido { get => ido; set => ido = value; }
        internal Pizza Pizza { get => pizza; set => pizza = value; }
        internal Cim Cim { get => cim; set => cim = value; }

        public override string ToString()
        {
            return $"{this.pizza} {this.darab} {this.cim} {this.ido.Hours}:{this.ido.Minutes}";
        }
    }
}
