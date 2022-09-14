
namespace Uppgift_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in lön1");
            float lön1 = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv in lön2");
            float lön2 = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv in lön3");
            float lön3 = float.Parse(Console.ReadLine());
            float medelvärde = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("medelvärde av " + lön1 + " plus " + lön2 + " plus " + lön3 + " är " + medelvärde + "kr");
        }
    }
}
