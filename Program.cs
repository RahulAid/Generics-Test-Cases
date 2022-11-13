
namespace Generics_Test_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems on Generics");

            int output = MaxNumberCheck.MaxIntegerNumber(111, 11, 2222);
            Console.WriteLine("\nMax integer number is: " + output);
        }
    }
}