using System;

namespace uppgift_2_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt hoppade Elin i meter ?");
            string HoppadeText = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hur långt hoppade Alma i meter ?");
            string hoppadeText2 = Console.ReadLine();
            Console.Clear();

            double hoppade = double.Parse(HoppadeText);
         
            Console.WriteLine("2 meter - 3 meter = skillnaden är 1 meter");
            Console.ReadKey();
        }
    }
}



