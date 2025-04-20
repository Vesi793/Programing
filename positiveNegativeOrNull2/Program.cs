namespace positiveNegativeOrNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine($"The number is zero.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number is positive: {num}");
            }
            else
            {
                Console.WriteLine($"The number is negative: {num}");
            }
        }
    }
}
