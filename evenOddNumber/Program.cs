namespace evenOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is even:  { number}");
            }
            else
            {
                Console.WriteLine($"The number is odd:  {number}");
            }


        }
    }
}
