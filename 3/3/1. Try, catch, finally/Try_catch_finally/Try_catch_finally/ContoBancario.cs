using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//-Esercizio 2: Gestire un `ContoBancario`

//    **Obiettivo * *: Creare una classe che gestisca uno stato interno e lo modifichi in modo controllato.


//    **Consegna * *:

//1.Crea una classe `ContoBancario` con una proprietà privata per il saldo(`_saldo`) 
//e una pubblica di sola lettura(`Saldo`) per esporlo.
//2.Nel costruttore, inizializza il saldo a un valore di partenza(es. 1000).
//3.Crea un metodo `Deposita(decimal importo)` che aggiunge un importo al saldo, ma solo se l'importo è positivo.
//4.Crea un metodo `Preleva(decimal importo)` che sottrae l'importo dal saldo, ma solo se l'importo è positivo
//E se il saldo è sufficiente.
//5.Nel `Main`, crea un `ContoBancario`, esegui alcune operazioni di deposito e prelievo(valide e non valide) 
//e stampa il saldo dopo ogni operazione.


namespace Try_catch_finally
{
    internal class ContoBancario
    {
        private decimal _saldo;
        //public decimal Saldo { get; set; }

        //public decimal Saldo //{ get; set; }
        //{
        //    get { return _saldo; }
        //    set
        //    {
        //        if (_saldo > 1000)
        //        {
        //            //istruzione
        //        }
        //    }
        //}

        public decimal Saldo()
        {
            this._saldo = 1000;
            Console.WriteLine(_saldo);
            return _saldo;
        }

        public decimal Deposita()
        {
            if (_saldo > 0)
            {
                _saldo += 100;
            }
            return _saldo;
        }

        public decimal Preleva()
        {
            if (_saldo > 0)
            {
                _saldo -= 100;

            }
            else if (_saldo <= 100)
            {
                Console.WriteLine("Non puoi prelevare" + _saldo);
            }
            return _saldo;
        }
    }
}


