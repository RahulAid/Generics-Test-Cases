
namespace Generics_Test_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems on Generics");

            MaxNumberCheck<int> objint = new MaxNumberCheck<int>(11, 111, 1111, 22222);
            Console.WriteLine("\nMax integer number is: " + objint.MaxMethod());

            MaxNumberCheck<float> objfloat = new MaxNumberCheck<float>(1, 11, 111, 2222);
            Console.WriteLine("\nMax float number is: " + objfloat.MaxMethod());

            MaxNumberCheck<string> objstring = new MaxNumberCheck<string>("Apple", "Peach", "Banana", "Guava");
            Console.WriteLine("\nMax string word is: " + objstring.MaxMethod());
        }
    }
}