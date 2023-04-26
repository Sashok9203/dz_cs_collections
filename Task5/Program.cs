namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int levelCount = 4;
            Stack<int> tower1 = new(), tower2 = new(), tower3 = new();

            for (int i = levelCount * 2 - 1; i > 0; i -= 2)
                tower1.Push(i);


        }
    }
}