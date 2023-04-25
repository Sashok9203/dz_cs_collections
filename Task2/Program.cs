using System.Runtime.InteropServices;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Max = "";
            List<string> stringList = new() 
            {
                "dog",
                "elephant", 
                "chocolate",
                "Embarrassment",
                "basketball", 
                "butterfly", 
                "computer",
                "strawberry", 
                "hippopotamus",
                "television",
                "international",
                "Unbelievable",
                "Accomplishment"
            };
            stringList.Sort();
            foreach (string str in stringList) 
               if(Max.Length< str.Length) Max = str;
            Console.WriteLine(Max);
        }
    }
}