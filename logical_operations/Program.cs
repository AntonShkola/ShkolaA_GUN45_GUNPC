class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter the value 1: ");

        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number");
            return;
        }

        Console.WriteLine();

        Console.WriteLine("Please, enter the value 2: ");

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number");
            return;
        }

        Console.WriteLine();

        Console.WriteLine("Your results: ");
        Console.WriteLine();

        Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
    }
}