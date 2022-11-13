
namespace Generics_Test_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems on Generics");

            float output = MaxNumberCheck.MaxFloatNumber(11f, 111f, 1111f);
            Console.WriteLine("\nMax float number is: " + output);
        }
    }
}