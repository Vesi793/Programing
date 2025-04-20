namespace findTheLargerOfTheTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("The first number is bigger.");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("The second number is bigger.");
            }
            else
            {
                Console.WriteLine("The numbers are equal.");
            }
        }
    }
}
