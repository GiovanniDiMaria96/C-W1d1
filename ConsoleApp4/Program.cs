namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> regali = new List<string>();
            //regali.Add("regalo1");
            //regali.Add("regalo2");
            //regali.Add("regalo3");
            //regali.Add("regalo4");
            ////regali.Remove("regalo1") //RIMUOVE

            //foreach (var item in regali)
            //{
            //    Console.WriteLine(item);
            //}

            List<Regalo> regali = new List<Regalo>();

            regali.Add(new Regalo { Nome = "automobile", Prezzo = 100});
            regali.Add(new Regalo { Nome = "videogioco", Prezzo = 100});
            regali.Add(new Regalo { Nome = "bicicletta", Prezzo = 100});
            regali.Add(new Regalo { Nome = "vestito", Prezzo = 100});
            foreach (var item in regali)
            {
            Console.WriteLine(item.Nome + item.Prezzo);
                
            }
        }
    }
}
