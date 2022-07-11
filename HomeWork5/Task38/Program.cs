void PrintArray (double [] Array)
{
    for (int i = 0; i < Array.Length; i++)
   {  
        Console.Write($" {Array[i]} ");
    }
}

double [] Array = new double [3];
double max = 0;
double min = 0;
double DiffMaxMin = 0;

for (int i = 0; i < Array.Length ; i++)
{
    Array[i] = new Random().NextDouble();
    if (Array[i] > max)
    {
        max = Array[i];
    }
    else if (Array[i] < min)
    {
        min = Array[i];
    }
} 
DiffMaxMin = max - min;

Console.Write("Случайный массив вещественных элементов:");
PrintArray(Array);
Console.WriteLine("Разница между максимальным элементом и минимальным: " + DiffMaxMin);

