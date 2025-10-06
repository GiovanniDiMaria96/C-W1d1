namespace Try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Esercizio 1: Gestione dell'Input dell'Utente

            #region Consegna
            /*
            Scrivi un programma che chiede all'utente la sua età. 
            Usa un blocco try-catch per intercettare la FormatException che si verifica se l'utente 
            inserisce un testo invece di un numero. In caso di errore, stampa un messaggio amichevole.            */
            #endregion
            #region Soluzione
            try
            {
                Console.WriteLine("Inserisci la tua età: ");
                int eta = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Inserisci un numero non una lettera:");
            }


            #endregion

            #endregion

            #region Esercizio 2: Divisione Sicura

            #region Consegna
            /*
            Scrivi un programma che chiede all'utente due numeri interi (un numeratore e un denominatore) 
            e ne calcola la divisione. Prevedi il caso in cui il denominatore sia zero, 
            gestendo l'eccezione DivideByZeroException.            */
            #endregion
            #region Soluzione
            try
            {
                Console.WriteLine("Inserisci il numeratore: ");
                int numeratore = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il denominatore: ");
                int denominatore = Convert.ToInt32(Console.ReadLine());

                int risultato = numeratore / denominatore;
                Console.WriteLine("Il risultato della divisione è: " + risultato);
            }

            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Impossibile dividere per '0' ");
            }




            #endregion

            #endregion

            #region Esercizio 3: Accesso a un Array

            #region Consegna
            /*
            Crea un array di 5 stringhe. Chiedi all'utente di inserire un indice e prova a stampare 
            l'elemento dell'array a quell'indice. Gestisci l'errore che si verifica se l'utente 
            inserisce un indice non valido.
            */
            #endregion
            #region Soluzione
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Opel" };
            Console.WriteLine("Inserisci un indice: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(cars[indice]);
            }
            catch (Exception)
            {
                Console.WriteLine("Inserisci un indice valido (da '1' a '5')");
            }

            #endregion

            #endregion
                
            #region Esercizio 4: Pulizia del Codice con finally

            #region Consegna
            /*
            Simula l'apertura di una risorsa (es. una connessione a un database). Stampa "Connessione aperta." nel blocco try. Stampa "Elaborazione dati..." sempre nel try. In caso di errore (simulalo con un throw), stampa un messaggio nel catch. Indipendentemente dal risultato, stampa "Connessione chiusa." nel blocco finally.         
            */
            #endregion

            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 5: Stampa di una Lista (foreach loop)

            #region Consegna
            /*
            Scrivi un programma che tenta di leggere il contenuto di un file di testo chiamato "documento.txt". Se il file non esiste, il programma dovrebbe intercettare l'eccezione FileNotFoundException e stampare un messaggio appropriato.
            */
            #endregion
            #region Soluzione
            try
            {
                File.ReadAllText("C:\\Users\\Laboratorio19\\Desktop\\C #\\Teoria\\documento.txt");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("C:\\Users\\Laboratorio19\\Desktop\\C #\\Teoria\\documento.txt");
                Console.WriteLine("File non trovato");
            }
            #endregion

            #endregion

            #region Esercizio 6: Creare un'Eccezione Personalizzata
            #region Consegna
            /*
            1. Crea una classe `EtaNegativaException` che eredita da `Exception`.
            2. Scrivi un metodo `ImpostaEta(int eta)` che lancia questa eccezione se l'età inserita è negativa.
            3. Nel `Main`, chiama questo metodo e gestisci l'eccezione personalizzata.            
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 7: Gestione Generica degli Errori

            #region Consegna
            /*
            Modifica l'Esercizio 2 (Divisione Sicura) in modo che abbia un solo blocco catch (Exception ex). Stampa il tipo di eccezione e il messaggio per capire quale errore si è verificato (FormatException o DivideByZeroException).
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 8: Conversione di Tipi di Dato

            #region Consegna
            /*
            1. Crea una variabile `object` e assegnale una stringa (es. `"ciao"`).
            2. In un blocco `try`, prova a fare un cast esplicito di questo oggetto a `int`.
            3. Nel blocco `catch`, intercetta l'`InvalidCastException` e stampa un messaggio di errore.            
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 9: try-finally senza catch

            #region Consegna
            /*
            Scrivi un metodo che simula l'allocazione di una risorsa. Usa un blocco try-finally per garantire che la risorsa venga sempre "rilasciata", anche se un errore si verifica nel try. Lascia che l'eccezione si propaghi al metodo chiamante (il Main), che la gestirà.            
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 10: Filtri di Eccezione (clausola when)

            #region Consegna
            /*
            Scrivi un programma che lancia un'eccezione `HttpRequestException` (simulata). Usa due blocchi `catch`:

            1. Il primo cattura l'eccezione solo `when` il suo messaggio contiene la parola "Timeout".
            2. Il secondo cattura tutte le altre `HttpRequestException`.         
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion



                            // INTRODUZIONE PROGRAMMAZIONE AD OGGETTI
            //ESERCIZIO 1
            Rettangolo rettangolo = new Rettangolo();
            Console.WriteLine("inserisci base:");
            int ba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci altezza: ");
            int altezza = Convert.ToInt32(Console.ReadLine());
            rettangolo.Altezza = altezza;
            rettangolo.Base = ba;
            rettangolo.Area();
            Console.WriteLine("Area: ");
            Console.WriteLine(rettangolo.Area());
            Console.WriteLine("Perimetro: ");
            Console.WriteLine(rettangolo.Perimetro());

            //ESERCIZIO 2

           //ESERCIZIO 3
                Lampadina lampadina = new Lampadina(); //L'ISTANZA FUORI DAL CICLO EVITA DI CREARE UNA NUOVA LAMPADINA OGNI VOLTA
            do
            {
                Console.WriteLine("1.Accendi la lampadina");
                Console.WriteLine("2.Spegni la lampadina");
                Console.WriteLine("3.Controlla se la lampadina è accesa o spenta");
                Console.WriteLine("0.Esci");
                int menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 3)
                {
                    lampadina.StampaStato();
                }
                else if (menu == 2)
                {
                    lampadina.Spegni();
                }
                else if (menu == 1)
                {
                    lampadina.Accendi();
                }
                else
                {
                    break;
                }
            }
            while (true);
        }
    }
}






