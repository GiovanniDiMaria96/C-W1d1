namespace Creazione_di_eccezioni_personalizzate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Esercizio 1: Validazione Formato Username

            #region Consegna
            /*
            1. Crea una classe `FormatoUsernameNonValidoException` che eredita da `Exception`.
            2. Scrivi un metodo `CreaUtente(string username)` che controlla il nome utente. Se contiene caratteri non validi, lancia la tua eccezione personalizzata.
            3. Nel `Main`, gestisci l'eccezione.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 2: Eccezione con Dati Aggiuntivi

            #region Consegna
            /*
            1. Crea una `SaldoInsufficiennteException` con proprietà `ImportoRichiesto` e `SaldoDisponibile`.
            2. Scrivi una classe `ContoBancario` con un metodo `Preleva(decimal importo)` che lancia questa eccezione se il saldo non è sufficiente.
            3. Nel `catch`, usa le proprietà dell'eccezione per stampare un messaggio dettagliato.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 3: Validazione nel Costruttore

            #region Consegna
            /*
            1. Crea una `PrezzoNonValidoException`.
            2. Crea una classe `Prodotto` il cui costruttore lancia questa eccezione se il prezzo passato è minore di zero.
            3. Nel `Main`, prova a creare un prodotto con un prezzo non valido e gestisci l'errore.
             */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 4: Errore di Basso Livello

            #region Consegna
            /*
            1. Crea una `SalvataggioUtenteFallitoException`.
            2. Crea un metodo `SalvaUtente` che simula un errore e lancia la tua eccezione.
            3. Gestisci l'errore nel `Main`.
            */
            #endregion

            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 5: Regola di Business Specifica

            #region Consegna
            /*
            1. Crea una `OrdineGiaSpeditoException`.
            2. Crea una classe `Ordine` con un metodo `Annulla()` che lancia l'eccezione se l'ordine è già stato spedito.
            3. Gestisci l'eccezione.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 6: Errore di Configurazione
            #region Consegna
            /*
            1. Crea una `FileDiConfigurazioneMancanteException`.
            2. Scrivi un metodo `CaricaConfigurazione(string percorso)` che lancia l'eccezione se il file non esiste.
            3. Gestisci l'errore.
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 7: Risorsa Esterna non Disponibile

            #region Consegna
            /*
            1. Crea una `StampanteOfflineException`.
            2. Crea una classe `Stampante` con un metodo `Stampa(string documento)` che lancia l'eccezione se la stampante non è online.
            3. Gestisci l'eccezione.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 8: Validazione di Permessi

            #region Consegna
            /*
            1. Crea una `AccessoNegatoException`.
            2. Crea una classe `Utente` e un metodo `EseguiOperazioneCritica(Utente utente)` che lancia l'eccezione se l'utente non è admin.
            3. Gestisci l'eccezione.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 9: Errore API di Terze Parti

            #region Consegna
            /*
            1. Crea una `ApiResponseErrorException` con proprietà per `StatusCode` e `Content`.
            2. Scrivi un metodo `ChiamaApi()` che simula un errore e lancia la tua eccezione.
            3. Nel `catch`, stampa i dettagli dell'errore.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 10: Logica di Gioco

            #region Consegna
            /*
            1. Crea una `SquadraAlCompletoException`.
            2. Crea una classe `Squadra` con un metodo `AggiungiGiocatore(string nome)` che lancia l'eccezione se la squadra è piena.
            3. Gestisci l'eccezione.       
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion
        }
    }
}

