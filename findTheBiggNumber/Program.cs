namespace findTheBiggNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
          
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine($"The biggest number is: {a}");
            }
        else if (b >= a && b >= c)
            {
                Console.WriteLine($"The biggest number is: {b}");
            }
            else
            {
                Console.WriteLine($"The biggest number is: {c}");
            }
        }
    }
}
