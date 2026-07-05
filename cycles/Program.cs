
class Programm
{
    static void Main()
    {
        // 1

        int[] arrayFib = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 33 };

        foreach (int i in arrayFib)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        // 2

        for (int i = 0; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

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

        // 4

        string password = "qwerty";
        string? userValue;

        do
        {
            Console.WriteLine("Please, enter the password");
            userValue = Console.ReadLine();

        } while (!(userValue == password));

        Console.WriteLine("Succes!");
    }
}
