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
         public int Perimetro () {

     return Base * Altezza;
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
// per quelle private: camelcase e underscore. esempio: private string _nomeVariabile { get; set; } (ACCESSIBILE SOLO ALL'INTERNO DELLA CLASSE)

//COSTRUTTORE (metodo che non da ritorno, non obbligatorio)
//costruttore default
// public Rettangolo () { }               //PascalCase es. TriangoloIsoscele() { }
//overloading del costruttore (inserendo proprietà non di default)
// public Rettangolo (double h, double b)
// {
//      this.Altezza = h;
// }

// METODI
//AccessModifier (SEGUITO DA) TipoDaRestituire (SEGUITO DA) NomeMetodo([eventuali parametri])
//{
//
//}
//es
// public void Benvenuto(){              ***(VOID NON RESTITUISCE NULLA, MA ESEGUE LE ISTRUZIONI DEL METODO)***
//  Console.WriteLine("Benvenuto!")
// }     



