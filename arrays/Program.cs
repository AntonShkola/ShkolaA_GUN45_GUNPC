
int[][] array  = new int[3][] 
{ 
    new[] { 12, 2, 3 }, 
    new[] { 13, 2, 3 }, 
    new[] { 32, 2, 3 } 
};

//Console.WriteLine(array[0]);
//Console.WriteLine(array[2][0]);


int[] testArray = new[] { 3, 2, 1, 4, 12 };
Array.Sort(testArray, 0, 4);
Console.WriteLine(testArray[0]);
Console.WriteLine(testArray[1]);
Console.WriteLine(testArray[2]);
Console.WriteLine(testArray[3]);
Console.WriteLine(testArray[4]);