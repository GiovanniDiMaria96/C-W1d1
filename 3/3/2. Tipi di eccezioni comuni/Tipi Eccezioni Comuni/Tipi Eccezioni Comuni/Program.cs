namespace Tipi_Eccezioni_Comuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Esercizio 1: L'Errore più Comune (NullReferenceException)

            #region Consegna
            /*
            1. Dichiara una variabile di tipo `string` chiamata `nome` e **non** assegnarle alcun valore (sarà `null` di default).
            2. In un blocco `try`, prova a stampare la sua lunghezza (`nome.Length`).
            3. Nel blocco `catch`, intercetta la `NullReferenceException` e stampa un messaggio che spiega l'errore.
             */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 2: Formato Data non Valido (FormatException)

            #region Consegna
            /*
            1. Chiedi all'utente di inserire la sua data di nascita nel formato "GG/MM/AAAA".
            2. Usa `DateTime.Parse()` per convertirla.
            3. Gestisci la `FormatException` che si verifica se l'utente scrive, ad esempio, "ieri" o "20-05-1990".
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 3: Argomento Nullo non Ammesso (ArgumentNullException)

            #region Consegna
            /*
            1. Scrivi un metodo `StampaNomeMaiuscolo(string nome)` che stampa un nome in maiuscolo.
            2. All'interno del metodo, controlla se `nome` è `null`. Se lo è, lancia `new ArgumentNullException(nameof(nome))`.
            3. Nel `Main`, chiama il metodo passandogli `null` e gestisci l'eccezione.
             */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 4: Valore Fuori Intervallo (ArgumentOutOfRangeException)

            #region Consegna
            /*
            Simula l'apertura di una risorsa (es. una connessione a un database). Stampa "Connessione aperta." nel blocco try. Stampa "Elaborazione dati..." sempre nel try. In caso di errore (simulalo con un throw), stampa un messaggio nel catch. Indipendentemente dal risultato, stampa "Connessione chiusa." nel blocco finally.         
            */
            #endregion

            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 5: Chiave non Trovata (KeyNotFoundException)

            #region Consegna
            /*
            1. Crea un `Dictionary<string, string>` per memorizzare alcune capitali (`"Italia" -> "Roma"`).
            2. Chiedi all'utente di inserire il nome di uno stato.
            3. Prova a stampare la capitale accedendo al dizionario con la chiave inserita dall'utente.
            4. Gestisci la `KeyNotFoundException`.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 6: Operazione non Valida (InvalidOperationException)
            #region Consegna
            /*
            1. Crea una `List<int>` vuota.
            2. Usa il metodo `First()` di LINQ, che lancia un'`InvalidOperationException` se la sequenza è vuota.
            3. Gestisci l'eccezione.
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 7: Accesso a File Inesistente (FileNotFoundException)

            #region Consegna
            /*
            Scrivi un programma che tenta di leggere un file con un nome a tua scelta (es. config.json). Gestisci l'eccezione FileNotFoundException stampando un messaggio che informa l'utente che il file non è stato trovato.            
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 8: Superamento dei Limiti di un Tipo (OverflowException)

            #region Consegna
            /*
            1. Dichiara una variabile `byte` (che va da 0 a 255) e inizializzala a `250`.
            2. Usa un blocco `checked` per eseguire un'operazione che causerà un overflow (es. aggiungere `10`).
            3. Gestisci l'`OverflowException`.        
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 9: Percorso File non Valido (NotSupportedException)

            #region Consegna
            /*
            Prova a creare un file usando File.Create() con un nome non valido, come "mio:file.txt". Gestisci la NotSupportedException che ne deriva.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 10: Timeout di un'Operazione (TimeoutException)

            #region Consegna
            /*
            1. Crea un `Task` che attende 5 secondi (`Task.Delay(5000)`).
            2. Usa `task.Wait(2000)` per attendere il completamento del task, ma con un timeout di soli 2 secondi. Questo metodo restituisce `false` se scade il tempo.
            3. Se `Wait` restituisce `false`, lancia `new TimeoutException()`.
            4. Gestisci l'eccezione.         
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion
        }
    }
}
