namespace FindTheBiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number!");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number!");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"The bigger number is: {num1}");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"The bigger number is: {num2}");
            }
            else 
                    {
                Console.WriteLine($"The numbers are equal!");
            }
        }
    }
}