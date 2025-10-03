namespace Struture_di_controllo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Esercizio 1: Positivo, Negativo o Zero (if-else if-else)

            #region Consegna
            /*
            Scrivi un programma che chiede all'utente di inserire un numero e poi stampa se il numero è "Positivo", "Negativo" o "Zero".
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 2: Giorno della Settimana (switch)

            #region Consegna
            /*
            Scrivi un programma che chiede all'utente di inserire un numero da 1 a 7 e stampa il giorno della settimana corrispondente (1 = Lunedì, 2 = Martedì, ...). Gestisci anche il caso in cui l'utente inserisca un numero non valido.
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 3: Tabellina (for loop)

            #region Consegna
            /*
            Scrivi un programma che chiede all'utente di inserire un numero e stampa la sua tabellina (da 1 a 10).
            */
            #endregion
            #region Output
            /*
            Console.WriteLine("Inserisci un numero iniziale: ");
            int moltiplicando = Convert.ToInt32(Console.ReadLine());
            int moltiplicatore = 10;
            for (int i = 0; i <= moltiplicatore; i++)
            {
                int prodotto =  moltiplicando* i;
                Console.WriteLine(prodotto);
            }
            */

            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 4: Somma dei Numeri Pari (for loop e if)

            #region Consegna
            /*
            Scrivi un programma che calcoli e stampi la somma di tutti i numeri pari da 1 a 100.          
            */
            #endregion

            #region Soluzione
                        Console.WriteLine("Questa è la somma di tutti i numeri pari da 1 a 100");
            int somma = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%2==0)
                {
                        somma = somma + i; 
                }

            }
                    Console.WriteLine(somma);
            #endregion

            #endregion

            #region Esercizio 5: Stampa di una Lista (foreach loop)

            #region Consegna
            /*
            Crea una List<string> con i nomi di alcuni frutti. Usa un ciclo foreach per stampare ogni frutto della lista a console.            
            */
            #endregion
            #region Soluzione
                        var lista = new List <string>() {"mela","pera","banana","kiwi","pesca"};
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            #endregion

            #endregion

            #region Esercizio 6: Gioco dell'Indovina Numero (while loop)
            #region Consegna
            /*
            Scrivi un gioco in cui il computer genera un numero casuale tra 1 e 100 e l'utente deve indovinarlo. Il programma continua a chiedere un numero finché l'utente non indovina, fornendo indizi ("Troppo alto" o "Troppo basso").
            */

            #endregion
            #region Soluzione
                        Random rnd = new Random();
            int casuale = rnd.Next(1,101);
            do
            {
                Console.WriteLine("Indovina il numero casuale:");
                int numeroInserito= Convert.ToInt32(Console.ReadLine());
                if (numeroInserito < casuale)
                {
                    Console.WriteLine("Numero troppo basso");
                }
                else if (numeroInserito > casuale)
                {
                    Console.WriteLine("Numero troppo alto");
                }
                else if (numeroInserito == casuale)
                {
                    Console.WriteLine("Numero esatto!");
                    break;
                }
            }
            while (true);
            #endregion

            #endregion

            #region Esercizio 7: Menu Interattivo (do-while loop)

            #region Consegna
            /*
            Crea un menu che mostra tre opzioni (es. 1. Stampa saluto, 2. Stampa data, 0. Esci). Il menu deve essere mostrato ripetutamente finché l'utente non sceglie l'opzione 0 per uscire.            
            */
            #endregion
            #region Soluzione
                        int menuController = 0;
            do
            {
                Console.WriteLine("1.Stampa saluto");
                Console.WriteLine("2.Stampa data");
                Console.WriteLine("0. Esci");
                menuController = Convert.ToInt32(Console.ReadLine());
                if (menuController == 0)
                {
                    break;  
                }

            }
            while (true);
            #endregion

            #endregion

            #region Esercizio 8: Disegnare un Triangolo (Cicli annidati)

            #region Consegna
            /*
            Scrivi un programma che chiede all'utente un numero n e disegna un triangolo rettangolo di asterischi (*) con altezza e base n.     
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 9: Calcolo del Fattoriale (while loop)

            #region Consegna
            /*
            Scrivi un programma che chiede all'utente un numero intero non negativo e ne calcola il fattoriale (es. 5! = 5 * 4 * 3 * 2 * 1).         
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion

            #region Esercizio 10: break e continue

            #region Consegna
            /*
            Scrivi un programma che itera sui numeri da 1 a 20.

            - Se il numero è dispari, salta all'iterazione successiva (`continue`).
            - Se il numero è divisibile per 4, stampalo.
            - Se il numero è maggiore di 16, esci dal ciclo (`break`).          
            */
            #endregion
            #region Soluzione

            #endregion

            #endregion
        }
    }
}



