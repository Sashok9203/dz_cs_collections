using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            PhoneBook pb = new();
            pb.AddReplace("Zazu Z.A.", "+38(063)529-02-99");
            pb.AddReplace("Zazu Z.A.", "+38(063)529-33-99");
            pb.AddReplace("Філіпов Є.Є.", "+38(097)530-50-50");
            pb.AddReplace("Ефремов Н.Ю.", "+38(050)500-45-30");
            if (pb.Get("Ефремов Н.Ю.", out string? phone)) Console.WriteLine(phone);
            pb.Del("Ефремов Н.Ю.");
            foreach (var item in pb)
               Console.WriteLine($"{item.Key} {item.Value}");
            
        }
    }
}