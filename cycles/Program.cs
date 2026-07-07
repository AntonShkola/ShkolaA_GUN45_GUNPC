
class Program
{
    static void Main()
    {
        // 1

        int[] arrayFib = new int[10]; 
        arrayFib[0] = 0;
        arrayFib[1] = 1;

        Console.WriteLine(arrayFib[0]);
        Console.WriteLine(arrayFib[1]);

        for (int i = 2; i < arrayFib.Length; i++)
        {                 
            arrayFib[i] = arrayFib[i-1] + arrayFib[i-2];
            Console.WriteLine(arrayFib[i]);
        }

        Console.WriteLine();

        // 2

        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        // 3

        for (int i = 1; i <= 5; i++)
        {       
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i * j);
                Console.Write("\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // 4

        string password = "qwerty";
        string? userValue;

        do
        {
            Console.WriteLine("Please, enter the password");
            userValue = Console.ReadLine();

        } while (userValue != password);

        Console.WriteLine("Succes!");
    }
}
