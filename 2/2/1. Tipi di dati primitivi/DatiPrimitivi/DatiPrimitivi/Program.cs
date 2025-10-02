namespace DatiPrimitivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Esercizio 1: Dichiarazione di Variabili

            #region Consegna
            /*
            1.Dichiara e inizializza una variabile per ognuno dei seguenti tipi:
            - Nome
            - Età
            - Anni
            - Altezza
            - Iniziale del congnome
            - Sta Studiando
            - Stipendio
            
            2. Stampa ogni variabile a console con una descrizione appropriata.
            */
            #endregion
            #region Output
            /*
            Output atteso:
            Nome: Mario Rossi
            Età: 30 anni
            Altezza: 1,75m
            Iniziale del Cognome: R
            Sta studiando C#?: True
            Stipendio: € 1.500,50
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 2: Input Utente e Calcoli Semplici

            #region Consegna
            /*
            1. Chiedi all'utente di inserire il suo anno di nascita.
            2. Calcola l'età approssimativa dell'utente sottraendo l'anno di nascita dall'anno corrente.
            3. Stampa a console l'età calcolata.
            
            */
            #endregion
            #region Output
            /*
            Output atteso:
            Inserisci il tuo anno di nascita: 1990
            Hai circa 35 anni.
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 3 - Extra: Controllo Pari o Dispari

            #region Consegna
            /*
            1. Chiedi all'utente di inserire un numero intero.
            2. Leggi e converti l'input in un `int`.
            3. Usa un `if-else` per controllare se il numero è pari o dispari. (Suggerimento: un numero è pari se il resto della divisione per 2 è 0).
            4. Stampa il risultato.
            */
            #endregion
            #region Output
            /*
            Inserisci un numero intero: 7
            Il numero 7 è dispari.
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 4: Limiti dei Tipi Interi

            #region Consegna
            /*
            1. Un `short` è un intero a 16 bit con segno, che va da -32,768 a 32,767.
            2. Dichiara una variabile di tipo `short` e prova ad assegnarle il valore `32767`. Stampala.
            3. Prova ad assegnarle il valore `32768`. Cosa succede? (Rispondi in un commento nel codice).
            4. Fai la stessa cosa con un `ushort` (intero a 16 bit senza segno), che va da 0 a 65,535.            */
            #endregion

            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 5: Scelta del Tipo di Dato Corretto

            #region Consegna
            /*
            Devi memorizzare il numero di studenti in una classe. 
            Sai che il numero non sarà mai negativo e non supererà mai 255. 
            Quale tipo di dato tra int, sbyte, byte e short è la scelta migliore e più efficiente in termini di memoria? 
            Dichiara una variabile di quel tipo e inizializzala.            
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 6: Precisione di float vs double
            #region Consegna
            /*
            1. Dichiara una variabile `float` e una `double`, entrambe con il valore `1.0 / 3.0`.
            2. Stampa entrambi i valori a console, mostrando quante più cifre decimali possibili (usa il formato `"F15"`).
            3. Osserva la differenza nel numero di cifre decimali precise.            */
            #endregion
            #region Output
            /*
            Valore float (precisione singola): 0,333333343267441
            Valore double (precisione doppia): 0,333333333333333
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 7: Calcoli Monetari con decimal

            #region Consegna
            /*
            1. Dichiara due variabili `decimal` per rappresentare due importi, ad esempio `100.05m` e `200.10m`.
            2. Sommale e stampa il risultato.
            3. Fai la stessa operazione con due variabili `double`. 
            Nota che in questo caso specifico il risultato potrebbe sembrare corretto, ma spiega in un commento perché `decimal` è comunque la scelta obbligata per la finanza.            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 8: Manipolazione di char

            #region Consegna
            /*
            1. Dichiara una variabile `char` con il valore `'7'`.
            2. Usa il metodo statico `char.IsDigit()` per verificare se il carattere è una cifra numerica e stampa il risultato (`bool`).
            3. Usa il metodo statico `char.GetNumericValue()` per convertirlo nel suo valore `double` equivalente e stampalo.            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 9: Concatenazione vs. Interpolazione di string

            #region Consegna
            /*
            1. Dichiara tre variabili: `string prodotto = "Laptop"`, `int quantita = 5`, `decimal prezzo = 1200.50m`.
            2. Crea una stringa di riepilogo usando la concatenazione classica (`+`).
            3. Crea la stessa stringa usando l'interpolazione (`$""`).
            4. Stampa entrambe per verificare che siano identiche.            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 10: Logica con bool

            #region Consegna
            /*
            Un utente può accedere a una risorsa se è un amministratore (`isAdmin`) OPPURE se è un utente registrato (`isRegistered`) E il suo account è attivo (`isAccountActive`).

            1. Dichiara tre variabili `bool`: `isAdmin = false`, `isRegistered = true`, `isAccountActive = true`.
            2. Scrivi un'unica espressione booleana che valuti la condizione di accesso.
            3. Stampa il risultato.            
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 11: Conversione Esplicita (Casting)

            #region Consegna
            /*
            1. Dichiara una variabile `double` con un valore decimale, es. `9.78`.
            2. Convertila esplicitamente in una variabile `int` usando il cast `(int)`.
            3. Stampa sia il valore originale `double` sia il valore `int` convertito.
            4. In un commento, spiega perché il risultato è quello che è.            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 12: long e ulong per Grandi Numeri

            #region Consegna
            /*
            1. Il valore massimo di un `int` è circa 2.1 miliardi.
            2. Dichiara una variabile `long` e assegnale un valore di 3 miliardi (scrivi `3000000000L` - la `L` finale è importante).
            3. Dichiara una variabile `ulong` e assegnale un valore ancora più grande, es. `15000000000UL`.
            4. Stampale entrambe.            
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 13: Valore di Default dei Tipi Primitivi

            #region Consegna
            /*
            1. Dichiara (senza inizializzare) le seguenti variabili come campi di una classe (non come variabili locali, altrimenti il compilatore darà errore).
                - `int i;`
                - `double d;`
                - `bool b;`
                - `char c;`
                - `string s;`
            2. Crea un'istanza della classe e stampa il valore di default di ogni campo.            */
            #endregion
            #region Output
            /*
            Default di int: 0
            Default di double: 0
            Default di bool: False
            Default di char (come int): 0
            Default di string: null
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion
        }
    }
}
