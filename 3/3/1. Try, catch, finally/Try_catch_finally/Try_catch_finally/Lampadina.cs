using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_finally
{
    internal class Lampadina
    {
        private bool _eAccesa;

        public bool Accendi()
        {
            if (!_eAccesa)
            {
                _eAccesa = true;
                Console.WriteLine("Hai acceso la lampadina");
            }
            return _eAccesa;

        }

        public bool Spegni()
        {
            if (_eAccesa)
            {
                _eAccesa = false;
                Console.WriteLine("Hai spento la lampadina");

            }
            return _eAccesa;

        }

        public void StampaStato()
        {
            if (_eAccesa)
            {
                Console.WriteLine("La lampadina è accesa");
            }
            else
            {
                Console.WriteLine("La lampadina è spenta ");
            }
            
        }
    }
}


//- Esercizio 3: Simulare una `Lampadina`


//** Obiettivo**: Modellare un oggetto con uno stato booleano(`on`/`off`).


//** Consegna**:

//1. Crea una classe `Lampadina` con una proprietà privata `_eAccesa`.
//2. Crea un metodo `Accendi()` che imposta lo stato su `true`, ma solo se la lampadina è spenta.
//3. Crea un metodo `Spegni()` che imposta lo stato su `false`, ma solo se la lampadina è accesa.
//4. Crea un metodo `StampaStato()` che stampa a console "La lampadina è accesa." o "La lampadina è spenta." a seconda dello stato.
//5. Nel `Main`, crea una lampadina, accendila, prova ad accenderla di nuovo, spegnila e stampa lo stato dopo ogni azione.
