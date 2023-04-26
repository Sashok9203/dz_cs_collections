using System.ComponentModel.DataAnnotations;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            const int DiskCount = 5; 
            TowersOfHanoi toh = new(DiskCount, 1000/ DiskCount, 1, 1);
            toh.Start();
        }
    }
}