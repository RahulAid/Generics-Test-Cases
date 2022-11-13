
namespace Generics_Test_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems on Generics");

            float output = MaxNumberCheck.MaxFloatNumber(11f, 2222f, 111f);
            Console.WriteLine("\nMax Float number is: " + output);
        }
    }
}