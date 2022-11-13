
namespace Generics_Test_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems on Generics");

            MaxNumberCheck objMaxNumber = new MaxNumberCheck();

            int output1 = objMaxNumber.MaxNumber<int>(11, 111, 2222);
            Console.WriteLine("\nMax integer number is: " + output1);

            float output2 = objMaxNumber.MaxNumber<float>(1, 11, 222);
            Console.WriteLine("\nMax float number is: " + output2);

            string output3 = objMaxNumber.MaxNumber<string>("Apple", "Peach", "Banana");
            Console.WriteLine("\nMax string word is: " + output3);
        }
    }
}