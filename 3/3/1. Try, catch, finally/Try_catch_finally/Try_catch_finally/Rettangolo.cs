using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_finally
{
    public class Rettangolo
    {
        public int Base { get; set; }
        public int Altezza { get; set; }
        public int Area()
        {
            return Base * Altezza / 2;
        }
    }
}



// PROPRIETA'
//modificatoreDiAccesso (SEGUITO DA) Tipo (SEGUITO DA) NomeProp { get; set; } (set per impostarlo e il get per restituire il valore)
// es.
// public int Altezza { get; set; }
// public string Altezza { get; set; }
// public float Altezza { get; set; }
//ecc..
//costruttore (metodo che non da ritorno, non obbligatorio)
//costruttore default
// public Rettangolo () { }
//overloading del costruttore (inserendo proprietà non di default)
// public Rettangolo (double h, double b)
// {
//      this.Altezza = h;
// }
// metodi
//AccessModifier (SEGUITO DA) TipoDaRestituire (SEGUITO DA) NomeMetodo([eventuali parametri])
//{
//
//}
//es
// public void Benvenuto(){              ***(VOID NON RESTITUISCE NULLA, MA ESEGUE LE ISTRUZIONI DEL METODO)***
//  Console.WriteLine("Benvenuto!")
// }
