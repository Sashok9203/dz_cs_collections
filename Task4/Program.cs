namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDeck deck = new();

            foreach (var item in deck)
                Console.WriteLine(item);
            Console.ReadKey();

            Console.Clear();
            deck.Shuffle();
            foreach (var item in deck)
                Console.WriteLine(item);
            Console.ReadKey();

            Console.Clear();
            while (!deck.IsEmpty)
            {
                Console.WriteLine(" -= Six of cards =-");
                foreach (var item in deck.GetSix())
                    Console.WriteLine($"     {item}");
                Console.WriteLine();
            }


        }
    }
}