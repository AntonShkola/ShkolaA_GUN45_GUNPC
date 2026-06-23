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

        Console.WriteLine("Please enter the bitwise operator symbol: &, | or ^");
 
        var s = Console.ReadLine();
        
        if (s !=null)
        {
            if (s.Length == 0 || s.Length > 1)
            {
                Console.WriteLine("Wrong sign");
                return;
            }
        }

        int result;

        Console.WriteLine();
        switch (s[0])
        {
            case '&':            
                result = a & b;
                Console.WriteLine("Decimal: {0} & {1} = {2}", a, b, result);
                Console.WriteLine("Binary:  {0} & {1} = 0b{2}", a, b, Convert.ToString(result, 2));
                Console.WriteLine("HEX:     {0} & {1} = 0x{2}", a, b, Convert.ToString(result, 16));
                break;
            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, a | b);
                break;
            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
                break;
            default: Console.WriteLine("Wrong sign");
                break;
        }     
    }
}