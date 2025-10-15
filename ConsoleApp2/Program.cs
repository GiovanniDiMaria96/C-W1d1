namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testo = "uno due tre due tre tre";
            string[] split = testo.Split(" ");
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (var item in split)
            {
                if (map.ContainsKey(item))
                {
                    map[item] += 1;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            foreach (var item in map)
            {
                Console.WriteLine(item.Key + item.Value);
            }
        }
    }
}
