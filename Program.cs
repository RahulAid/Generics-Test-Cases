
namespace Generics_Test_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems on Generics");

            string output = MaxNumberCheck.MaxStringWord("Apple", "Banana", "Peach");
            Console.WriteLine("\nMax String word is: " + output);
        }
    }
}