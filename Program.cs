namespace Assignment_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");

            // 1.1.2
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sum: {a + b}");

            // 1.1.3
            Console.WriteLine($"Quotient: {a / b}");
            Console.WriteLine($"Remainder: {a % b}");

        }
    }
}
