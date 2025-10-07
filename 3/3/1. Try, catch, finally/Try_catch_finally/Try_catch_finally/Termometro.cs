using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Esercizio 1: Il Termometro Intelligente

//** Obiettivo**: Incapsulare un dato(la temperatura) e fornire metodi pubblici per accedervi in modi diversi,
//senza esporre il dato grezzo.


//**Consegna * *:

//1.Crea una classe `Termometro`.
//2.Aggiungi un campo privato `_temperaturaCelsius` di tipo `double`.
//3.Crea un costruttore che accetta una temperatura iniziale in Celsius e la memorizza nel campo privato.
//4.Crea una proprietà pubblica di sola lettura `Celsius` che restituisce il valore di `_temperaturaCelsius`.
//5.Crea una proprietà pubblica di sola lettura `Fahrenheit` che converte la temperatura da Celsius a
//Fahrenheit e la restituisce.La formula è: `(Celsius * 9 / 5) + 32`.
//6.Nel `Main`, crea un'istanza di `Termometro` e stampa la temperatura in entrambe le unità di misura.

namespace Try_catch_finally
{
    public class Termometro
    {
        private double _temperaturaCelsius;
        public double Celsius
        {
            get { return _temperaturaCelsius; }
        }
        public double Fahrenheit
        {
            get { return (Celsius * 9 / 5) + 32; }
        }

        public Termometro(double temp)
        {
            _temperaturaCelsius = temp;
        }
    }
}

