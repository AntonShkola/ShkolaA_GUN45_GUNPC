
class Program
{
    static void Main()
    {
        // 1
        int[] numFib = new int[] { 0, 1, 2, 3, 5, 8, 13, 21 };

        // 2
        string[] months = new string[12]
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        // 3
        int[,] matrix = new int[3, 3]
        {
            {2, 3, 4},
            {4, 6, 8},
            {16, 27, 64}
        };

        // 4
        double[][] jagg = new double[3][];
        jagg[0] = new double [] { 1, 2, 3, 4, 5 };
        jagg[1] = new double [] {Math.E, Math.PI };
        jagg[2] = new double[]
        {
            Math.Log10 (1.0),
            Math.Log10 (10.0),
            Math.Log10 (100.0),
            Math.Log10 (1000.0)
        };

        // 5
        int[] array = { 1, 2, 3, 4, 5, };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13, };
        Array.Copy(array, array2, 3);

        foreach (int i in array2)
        {
            Console.WriteLine(i);
        }

        // 6
        Console.WriteLine();
        Array.Resize(ref array, array.Length*2);
        Console.WriteLine(array.Length);     
    }
}