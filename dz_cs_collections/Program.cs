using System.Collections;

namespace dz_cs_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<bool> boolList = new();
            List<int> intList = new();
            List<Double> doubleList = new();

            ArrayList arrayList = new()
            {
              155, false , 12 , true , 1.1 , false , 78 , 90 , false ,
              113 , 56 , true , 34.6 , true , 67.89 , 100.2 , 122.3 , true
            };

            foreach (var item in arrayList)
            {
                switch (item)
                {
                    case bool b:
                        boolList.Add(b);
                        break;
                    case int i:
                        intList.Add(i);
                        break;
                    case double d:
                        doubleList.Add(d);
                        break;
                }
            }

            Console.Write($"Bool list   :");
            foreach (var item in boolList)
                Console.Write($"{item} ");
            Console.WriteLine();

            Console.Write($"Int list    :");
            foreach (var item in intList)
                Console.Write($"{item} ");
            Console.WriteLine();

            Console.Write($"Double list :");
            foreach (var item in doubleList)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}