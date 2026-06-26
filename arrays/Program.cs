
int[] array1 = new[] { 42, 3, 12, 552 };
float[] array2 = new[] { 12.56f, 6.5f, 72.1f, 32, 98f };

var results = Array.CreateInstance(typeof(float), 4);
results.SetValue(array1[0] * array2[0], 0);
//Console.WriteLine(results.GetValue(0));

//Array.Reverse(array2);
Console.WriteLine(array2.Min());
Console.WriteLine(array2.Max());
