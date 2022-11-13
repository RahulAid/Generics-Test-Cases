
namespace Generics_Test_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems on Generics");

            string output = MaxNumberCheck.MaxStringWord("Apple", "Peach", "Banana");
            Console.WriteLine("\nMax String word is: " + output);
        }
    }
}