using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Prodotto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Prezzo { get; set; }
        public int QuantitaDisponibile { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Prezzo: {Prezzo}";
        }
    }
}
