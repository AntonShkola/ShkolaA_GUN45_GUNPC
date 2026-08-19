internal class Programm
{
    static void Main()
    {
        int number = 10;

        unsafe
        {
            int* ptr = &number;
            Console.WriteLine((long)ptr);
        }
    }
}