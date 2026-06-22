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

        var s = Console.ReadLine();
        if (s.Length == 0 || s.Length > 1)
        {
            Console.WriteLine("Wrong sign");
            return;
        }

        switch(s[0])
        {
            case '&':
                Convert.ToString(a, 2);
                Convert.ToString(b, 2);
                Console.WriteLine("Result of {0} & {1} = {2}", a, b, a & b);
                break;
            case '-':
                Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
                break;
            case '*':
                Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
                break;
            case '/':
                Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
                break;
            case '%':
                Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
                break;
            default: Console.WriteLine("Wrong sign");
                break;
        }

        //Console.WriteLine("Your results: ");
         
    }
}