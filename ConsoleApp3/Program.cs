namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> regali = new List<string>();
            regali.Add("regalo1");
            regali.Add("regalo2");
            regali.Add("regalo3");
            regali.Add("regalo4");
            //regali.Remove("regalo1") //RIMUOVE

            foreach (var item in regali)
            {
                Console.WriteLine(item);
            }
        }
    }
}

