namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prodotti = new List<Prodotto>

            {

            new Prodotto { Id = 0, Nome = "a", Categoria = "x", Prezzo = 1, QuantitaDisponibile = 90},
            new Prodotto { Id = 1, Nome = "b", Categoria = "y", Prezzo = 2, QuantitaDisponibile = 80 },
            new Prodotto { Id = 2, Nome = "Elettronica", Categoria = "Elettronica", Prezzo = 3, QuantitaDisponibile = 70 },
            new Prodotto { Id = 2, Nome = "Cellulare", Categoria = "Elettronica", Prezzo = 50, QuantitaDisponibile = 70 },
            new Prodotto { Id = 2, Nome = "Notebook", Categoria = "Elettronica", Prezzo = 40, QuantitaDisponibile = 70 },
            new Prodotto { Id = 2, Nome = "Hard disk", Categoria = "Elettronica", Prezzo = 30, QuantitaDisponibile = 70 },
            new Prodotto { Id = 2, Nome = "Melanzana", Categoria = "Alimentari", Prezzo = 2, QuantitaDisponibile = 70 },
            new Prodotto { Id = 2, Nome = "Peperone", Categoria = "Alimentari", Prezzo = 2, QuantitaDisponibile = 70 },
            new Prodotto { Id = 2, Nome = "Latte", Categoria = "Alimentari", Prezzo = 4, QuantitaDisponibile = 70 },
            new Prodotto { Id = 2, Nome = "Uova", Categoria = "Alimentari", Prezzo = 3, QuantitaDisponibile = 70 },
            new Prodotto { Id = 3, Nome = "d", Categoria = "o", Prezzo = 4, QuantitaDisponibile = 60 }

            };

            //foreach (var item in prodotti)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //var elettronica = prodotti.Where(n => n.Categoria == "Elettronica" && n.QuantitaDisponibile > 0);
            //var elementi = elettronica.OrderBy(n => n.Prezzo);

            //foreach (var item in elementi)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            var magazzino = prodotti
                .GroupBy(n => n.Categoria)
                .Select(y => new
                {
                    Categoria = y.Key,
                    PrezzoMedio = y.Average(prodotto => prodotto.Prezzo)
                });

            foreach (var item in magazzino)
            {
                Console.WriteLine(item.Categoria +  item.PrezzoMedio);   
            }










        }
    }
}
