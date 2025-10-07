using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-Esercizio 2: Gestione Inventario di un Prodotto
    
//    **Obiettivo**: Proteggere lo stato di un oggetto (la quantità in magazzino) da valori non validi usando la logica nei metodi pubblici.
    
//    **Consegna**:
    
//    1.Crea una classe `Prodotto` con una proprietà pubblica `Nome` e un campo privato `_quantitaInMagazzino`.
//    2. Aggiungi una proprietà pubblica `QuantitaDisponibile` di sola lettura che
//    restituisce il valore di `_quantitaInMagazzino`.
//    3. Nel costruttore, inizializza il nome e la quantità iniziale.
//    4. Crea un metodo pubblico `AggiungiScorte(int quantita)` che aggiunge la quantità al magazzino.
//    Il metodo deve impedire l'aggiunta di quantità negative o nulle.
//    5. Crea un metodo pubblico `RimuoviScorte(int quantita)` che rimuove la quantità. Il metodo deve
//    impedire la rimozione di quantità non valide (negative/nulle) o di una quantità superiore a quella disponibile.
//    6. Nel `Main`, simula la gestione di un prodotto, testando sia operazioni valide che non valide.

namespace Try_catch_finally
{
    public class Prodotto
    {
        public string Nome { get; private set; }
        private int _quantitaInMagazzino;

        public int QuantitaDisponibile {
            get {return _quantitaInMagazzino;}
        }

        public Prodotto (string uno, int due)
        {
            Nome = uno;
            _quantitaInMagazzino = due > 0 ? due : 0;
        }
        public int AggiungiScorte(int quantita) {

            if (quantita > 0)
            {
                _quantitaInMagazzino += quantita;
            }
            else
            {
                Console.WriteLine("Inserisci un numero");
            }
                return _quantitaInMagazzino;
        }
        public int RimuoviScorte(int quantita) {
            if (quantita > _quantitaInMagazzino)
            {
                Console.WriteLine("Impossibile rimuovere la quantità desiderata: Quantità maggiore della quanità in magazzino");
            } else if (quantita < 0) 
            {
                Console.WriteLine("Inserire un numero positivo");
            } else
            {
                quantita -= _quantitaInMagazzino;
            }
                return _quantitaInMagazzino;
        }
    }
}
